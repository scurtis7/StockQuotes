import { Component, OnInit } from '@angular/core';
import {Stock} from '../stock';
import {StockService} from '../stock.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  stock: Stock = null;

  constructor(private stockService: StockService) { }

  ngOnInit() {
  }

  search(searchValue: string) {
    console.log('Stock quote search for: ' + searchValue);
    this.stockService.getStockQuote(searchValue)
      .subscribe(result => this.stock = result);
  }
}
