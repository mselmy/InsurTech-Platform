import { insurtechTemplatePage } from './app.po';

describe('insurtech App', function() {
  let page: insurtechTemplatePage;

  beforeEach(() => {
    page = new insurtechTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
