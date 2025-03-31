import { Routes } from '@angular/router';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { AboutComponent } from './pages/about/about.component';
import { ContactComponent } from './pages/contact/contact.component';

export const routes: Routes = [
    {path: '', component: HomePageComponent},
    {path: 'about', component: AboutComponent},
    {path: 'contact', component: ContactComponent},
];
