import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable, of} from 'rxjs';
import {Stock} from './stock';
import {catchError} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class StockService {
  private readonly baseUrl = 'api/quote';

  constructor(private http: HttpClient) {
  }

  getStockQuote(symbol: string): Observable<Stock> {
    const url = `${this.baseUrl}/${symbol}`;
    return this.http.get<Stock>(url).pipe(
      catchError(this.handleError<Stock>(`getStockQuote symbol = ${symbol}`))
    );
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    };
  }
}
