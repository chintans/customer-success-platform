import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AuditService {
  headers: HttpHeaders;
  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({
      ContentType: 'application/json; charset=utf-8',
    });
  }
  baseUrl = 'https://localhost:44347/api/app/audit-history';
  //CRUD operation for BUDGET
  getAudit() {
    return this.http.get(this.baseUrl);
  }

  createAudit(data: any) {
    console.log(data)
    return this.http.post(this.baseUrl, data);
  }

  deleteAudit(id: string) {
    return this.http.delete(this.baseUrl + `/${id}`);
  }

  updateAudit(id: string, data: any) {
    console.log(data)
    return this.http.put(this.baseUrl + `/${id}`, data);
  }
}
