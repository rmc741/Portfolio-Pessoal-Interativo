import { Component } from '@angular/core';
import { HomeComponent } from "../../components/home/home.component";
import { AboutComponent } from "../../components/about/about.component";
import { ContactComponent } from "../../components/contact/contact.component";

@Component({
  selector: 'app-home-page',
  imports: [HomeComponent, AboutComponent, ContactComponent],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent {

}
