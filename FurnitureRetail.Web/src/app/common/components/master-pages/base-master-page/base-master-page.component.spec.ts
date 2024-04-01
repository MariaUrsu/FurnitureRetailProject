import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BaseMasterPageComponent } from './base-master-page.component';

describe('BaseMasterPageComponent', () => {
  let component: BaseMasterPageComponent;
  let fixture: ComponentFixture<BaseMasterPageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BaseMasterPageComponent]
    });
    fixture = TestBed.createComponent(BaseMasterPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
