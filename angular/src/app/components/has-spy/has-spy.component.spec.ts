import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HasSpyComponent } from './has-spy.component';

describe('HasSpyComponent', () => {
  let component: HasSpyComponent;
  let fixture: ComponentFixture<HasSpyComponent>;
  let spybo: any;

  beforeEach(async(() => {
    
    spybo = jasmine.createSpyObj('obo', ['foobo', 'foogo']);

    TestBed.configureTestingModule({
      declarations: [ HasSpyComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HasSpyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('foo', () => {

  });
});
