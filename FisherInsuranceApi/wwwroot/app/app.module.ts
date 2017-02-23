import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import 'rxjs/Rx';

// import our application component
import { AppComponent } from './components/appdef/app.component';
import { HomeComponent } from './components/home/home.component'
@NgModule({
    declarations: [
        AppComponent,
        HomeComponent
    ],
    imports: [
        BrowserModule,
        HttpModule
    ],
    providers: [
    ],
    bootstrap: [
        AppComponent
    ],
})

export class AppModule { } 