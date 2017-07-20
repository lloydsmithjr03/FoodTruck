import { FoodTruck.WebPage } from './app.po';

describe('food-truck.web App', () => {
  let page: FoodTruck.WebPage;

  beforeEach(() => {
    page = new FoodTruck.WebPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
