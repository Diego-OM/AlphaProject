import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectMainListComponent } from './project-main-list.component';

describe('ProjectMainListComponent', () => {
  let component: ProjectMainListComponent;
  let fixture: ComponentFixture<ProjectMainListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProjectMainListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectMainListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
