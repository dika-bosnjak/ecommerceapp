import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Brand } from '../shared/models/brand';
import { Pagination } from '../shared/models/pagination';
import { Product } from '../shared/models/product';
import { ShopParams } from '../shared/models/shopParams';
import { Type } from '../shared/models/type';

@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = 'https://localhost:5001/api/'

  constructor(private http: HttpClient) { }

  getProducts(filterParams: ShopParams) {
    let params = new HttpParams();

    if (filterParams.brandId > 0) params = params.append('brandId', filterParams.brandId);
    if (filterParams.typeId) params = params.append('typeId', filterParams.typeId);
    params = params.append('sort', filterParams.sort);
    params = params.append('pageIndex', filterParams.pageNumber);
    params = params.append('pageSize', filterParams.pageSize);
    if (filterParams.search) params = params.append('search', filterParams.search);

    return this.http.get<Pagination<Product[]>>(this.baseUrl + 'products', {params});
  }

  getBrands() {
    return this.http.get<Brand[]>(this.baseUrl + 'products/brands');
  }

  getTypes() {
    return this.http.get<Type[]>(this.baseUrl + 'products/types');
  }
}
