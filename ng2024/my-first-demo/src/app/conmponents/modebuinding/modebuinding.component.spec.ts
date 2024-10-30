import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModebuindingComponent } from './modebuinding.component';

describe('ModebuindingComponent', () => {
  let component: ModebuindingComponent;
  let fixture: ComponentFixture<ModebuindingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ModebuindingComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModebuindingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
