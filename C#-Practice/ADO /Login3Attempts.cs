using System;
using System.Windows.Form;

public class LoginForm:Form
{
    private string correctusername = "Karan";
    private string correctpass = "abc";
    private int LoginAttempt = 3;
    
    public LoginForm(){
        InitializeComponent();
    }
    
    public void LoginForm_Load(Object Sender, EventArgs e){
        
        Label l1 - new Label();
        l1.text= "Username";
        l1.Location - new Point(200,50);
        l1.autosize = true;
        this.Controls.add(l1);
        
        TextBox t1 = new TextBox();
        t1.Location - new Point(250,70);
        t1.autosize = true;
        this.Controls.add(t1);
        
        Label l2 - new Label();
        l2.text= "Password";
        l2.Location - new Point(200,70);
        l2.autosize = true;
        this.Controls.add(l1);
        
        TextBox t2 - new TextBox();
        t2.Location - new Point(250,70);
        t2.autosize = true;
        this.Controls.add(t2);
        
        Button Login = new Button();
        Login.text = "Login";
        Login.Location = new Point(230, 150);
        Login.autosize = true;
        // login.Click += Login_Click;
        this.Controls.add(Login);
    }
    
    private void Login_Click(object sender, EventArgs e){
        string inputusername = t1,text.Trim();
        string inputpass = t2,text.Trim();
        
        if(LoginAttempt>0 && correctusername==inputusername && correctpass==inputpass){
            MessageBox.Show("Login Successfull !!");
            this.Close();
        }
        else{
            LoginAttempt--;
            
            if(LoginAttempt==0){
                MessageBox.Show("You have used all the Login Attempts!");
            }
            else{
                MessageBox.Show(LoginAttempt+ "Attempts Left")
            }
        }
    }
}
