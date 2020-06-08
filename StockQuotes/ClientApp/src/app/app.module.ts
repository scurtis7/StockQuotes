import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import {RouterModule} from '@angular/router';

import {AppComponent} from './app.component';
import {AppRoutingModule} from './app-routing.module';
import {QuotesComponent} from './quotes/quotes.component';
import {SearchComponent} from './search/search.component';
import {AboutComponent} from './about/about.component';
import {SigninComponent} from './signin/signin.component';
import {StockService} from './stock.service';

@NgModule({
  declarations: [
    AppComponent,
    QuotesComponent,
    SearchComponent,
    AboutComponent,
    SigninComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([]),
    AppRoutingModule
  ],
  providers: [
    StockService
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
