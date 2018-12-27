import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ArrayComponent } from './components/array/array.component';
import { BlankComponent } from './components/blank/blank.component';
import { HasSpyComponent } from './components/has-spy/has-spy.component';

@NgModule({
  declarations: [
    AppComponent,
    ArrayComponent,
    BlankComponent,
    HasSpyComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
