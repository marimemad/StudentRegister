import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavigationTapsComponent } from './navigation-taps.component';

describe('NavigationTapsComponent', () => {
  let component: NavigationTapsComponent;
  let fixture: ComponentFixture<NavigationTapsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NavigationTapsComponent]
    });
    fixture = TestBed.createComponent(NavigationTapsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
