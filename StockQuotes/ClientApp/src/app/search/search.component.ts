import {Component, Input, OnInit} from '@angular/core';
import {Stock} from '../stock';
import {StockService} from '../stock.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  @Input() stock: Stock;

  constructor(private stockService: StockService) { }

  ngOnInit() {
    // Used for testing styling
    // this.stock = {'close': 11.11, 'high': 22.22, 'low': 33.33, 'open': 44.44, 'price': 55.55, 'time': 1234567};
  }

  search(searchValue: string) {
    console.log('Stock quote search for: ' + searchValue);
    this.stockService.getStockQuote(searchValue)
      .subscribe(result => this.stock = result);
  }

}
