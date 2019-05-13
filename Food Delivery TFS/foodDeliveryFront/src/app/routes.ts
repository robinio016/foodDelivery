import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { RestaurantListComponent } from './restaurant-list/restaurant-list.component';
import { RestaurantComponent } from './restaurant/restaurant.component';
import { LoginComponent } from './security/login/login.component';
import { CheckoutComponent } from './checkout/checkout.component';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'restaurants', component: RestaurantListComponent},
    { path: 'restaurant', component: RestaurantComponent},
    { path: 'login', component: LoginComponent},
    { path: 'checkout', component: CheckoutComponent },
    { path: '**', redirectTo: '', pathMatch: 'full' }
];
