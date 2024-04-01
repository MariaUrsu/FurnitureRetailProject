import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SimpleMasterPageComponent } from './simple-master-page.component';

describe('SimpleMasterPageComponent', () => {
  let component: SimpleMasterPageComponent;
  let fixture: ComponentFixture<SimpleMasterPageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SimpleMasterPageComponent]
    });
    fixture = TestBed.createComponent(SimpleMasterPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
