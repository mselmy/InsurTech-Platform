import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditMotorInsurancePlanComponent } from './edit-motor-insurance-plan.component';

describe('EditMotorInsurancePlanComponent', () => {
  let component: EditMotorInsurancePlanComponent;
  let fixture: ComponentFixture<EditMotorInsurancePlanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditMotorInsurancePlanComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditMotorInsurancePlanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
