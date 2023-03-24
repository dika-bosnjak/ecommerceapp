import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { delay, finalize, identity, Observable } from 'rxjs';
import { LoaderService } from '../services/loader.service';
import { environment } from 'src/environments/environment.development';

@Injectable()
export class LoadingInterceptor implements HttpInterceptor {

  constructor(private loaderService: LoaderService) { }

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    if (
      request.url.includes('emailExists') ||
      request.method === 'POST' && request.url.includes('orders') ||
      request.method === 'DELETE'
    ) {
      return next.handle(request);
    }

    this.loaderService.load();
    return next.handle(request).pipe(
      (environment.production ? identity: delay(200)),
      finalize(() => this.loaderService.idle())
    );
  }
}
