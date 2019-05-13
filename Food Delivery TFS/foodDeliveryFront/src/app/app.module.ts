import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AccordionModule, RatingModule, CollapseModule, TabsModule, ModalModule, BsDropdownModule, ButtonsModule } from 'ngx-bootstrap';
import { AgmCoreModule } from '@agm/core';

import { ScrollSpyModule } from '@thisissoon/angular-scrollspy';
import { InViewportModule } from '@thisissoon/angular-inviewport';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { FooterComponent } from './footer/footer.component';
import { HomeComponent } from './home/home.component';
import { RouterModule } from '@angular/router';
import { appRoutes } from './routes';
import { RestaurantListComponent } from './restaurant-list/restaurant-list.component';
import { RestaurantComponent } from './restaurant/restaurant.component';
import { IngredientToAddModalComponent } from './restaurant/ingredient-to-add-modal/ingredient-to-add-modal.component';
import { CartComponent } from './cart/cart.component';
import { LoginComponent } from './security/login/login.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { AddressModalComponent } from './address-modal/address-modal.component';

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      FooterComponent,
      HomeComponent,
      RestaurantListComponent,
      RestaurantComponent,
      IngredientToAddModalComponent,
      CartComponent,
      LoginComponent,
      CheckoutComponent,
      AddressModalComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      InViewportModule,
      CollapseModule.forRoot(),
      RouterModule.forRoot(appRoutes),
      RatingModule.forRoot(),
      TabsModule.forRoot(),
      ScrollSpyModule.forRoot(),
      AccordionModule.forRoot(),
      ModalModule.forRoot(),
      BsDropdownModule.forRoot(),
      ButtonsModule.forRoot(),
      AgmCoreModule.forRoot({
         apiKey: 'AIzaSyD2_kK2N8cng42MZ6no7JDliwC6Hfgeyy4'
       })
   ],
   entryComponents: [
      IngredientToAddModalComponent,
      AddressModalComponent
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
