import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GetallbookingComponent } from './getallbooking.component';

describe('GetallbookingComponent', () => {
  let component: GetallbookingComponent;
  let fixture: ComponentFixture<GetallbookingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GetallbookingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GetallbookingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
