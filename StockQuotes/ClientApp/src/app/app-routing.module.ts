import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {AboutComponent} from './about/about.component';
import {QuotesComponent} from './quotes/quotes.component';
import {SearchComponent} from './search/search.component';
import {SigninComponent} from './signin/signin.component';

const routes: Routes = [
  {path: 'about', component: AboutComponent},
  {path: 'quotes', component: QuotesComponent},
  {path: 'search', component: SearchComponent},
  {path: 'signin', component: SigninComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
