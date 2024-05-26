import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditHomeInsurancePlanComponent } from './edit-home-insurance-plan.component';

describe('EditHomeInsurancePlanComponent', () => {
  let component: EditHomeInsurancePlanComponent;
  let fixture: ComponentFixture<EditHomeInsurancePlanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditHomeInsurancePlanComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditHomeInsurancePlanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
