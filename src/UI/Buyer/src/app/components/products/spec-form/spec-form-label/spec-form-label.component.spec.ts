import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { SpecFormLabelComponent } from './spec-form-label.component';

describe('SpecFormLabelComponent', () => {
  let component: SpecFormLabelComponent;
  let fixture: ComponentFixture<SpecFormLabelComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [SpecFormLabelComponent],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SpecFormLabelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
