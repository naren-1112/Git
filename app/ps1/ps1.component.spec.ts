import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ps1Component } from './ps1.component';

describe('ps1Component', () => {
  let component: ps1Component;
  let fixture: ComponentFixture<ps1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ps1Component ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ps1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
