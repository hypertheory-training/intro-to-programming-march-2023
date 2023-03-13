describe('The Support Page', () => {
    describe('The Help And Support Contact Information', () => {
      beforeEach(() => {
        cy.visit('/support');
      });
  
      it('has the support component displayed', () => {
        cy.get('[data-testid="contact-info"]').should('exist');
      });
      it('has the contact name', () => {
        cy.get('[data-testid="contact-info"]')
          .find('[data-testid="name"]')
          .should('contain.text', 'OnCallCorp Customer Service');
      });
    });
  });