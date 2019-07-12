import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CategorizedMerchantComponent } from './categorizedMerchant.component';

describe('CategorizedMerchantComponent', () => {
  let component: CategorizedMerchantComponent;
  let fixture: ComponentFixture<CategorizedMerchantComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CategorizedMerchantComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CategorizedMerchantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
