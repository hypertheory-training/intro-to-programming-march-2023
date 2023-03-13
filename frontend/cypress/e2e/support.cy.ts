describe('The Support Page', () => { 
     describe('The Help And Support Contact Information', () => {
     it('has the support component displayed', () => {
     cy.visit('/support');
     cy.get('[data-testid="contact-info"]').should('exist');
     });
     });
    });