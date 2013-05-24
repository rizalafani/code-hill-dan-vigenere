/*
 * Created by SharpDevelop.
 * User: MADARA UCHIHA
 * Date: 13/05/2013
 * Time: 10:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace UTS_FORM
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
				
		void Button1Click(object sender, EventArgs e)
		{
			try{
				string[] arr_huruf = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
				if(txt_plaintext.Text != "" && txt_baris.Text != "" && txt_kolom.Text != "" && txt_matrik.Text != "" && txt_key_vigenere.Text != ""){
					if((txt_plaintext.Text.Replace(" ","").Length % int.Parse(txt_kolom.Text)) == 0){
						byte i = 0;
						int[,] arr_matrik = new int[byte.Parse(txt_baris.Text),byte.Parse(txt_kolom.Text)];
						string matrik_1 = txt_matrik.Text.Substring(0,txt_matrik.Text.Length-1);
						foreach(string word in matrik_1.Replace(" ","").Split(';')){
							byte j = 0;
							foreach(string word2 in word.Split(',')){
								arr_matrik[i,j] = Convert.ToInt32(word2);
								j++;
							}
							i++;
						}
						txt_chiper.Text += "Plaintext = "+txt_plaintext.Text+"\r\n";
						txt_chiper.Text += "Matrik = "+txt_matrik.Text+"\r\n\r\n\r\n";
						CodeHill(arr_huruf,arr_matrik,txt_plaintext.Text);
					}else{
						MessageBox.Show("Tambahkan "+(int.Parse(txt_kolom.Text) - (txt_plaintext.Text.Replace(" ","").Length % int.Parse(txt_kolom.Text)))+" character untuk melengkapi plaintext anda !!");
					}
				}else{
					MessageBox.Show("input masih gak lengkap !!","warning !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
			}catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}					
		}
		
		private int GetIndexHuruf(string[] list_huruf,string huruf){
			int index = -1;
			for(byte i = 0; i<list_huruf.Length; i++){
				if(list_huruf[i] == huruf){
					index = i;
				}
			}
			return index;
		}
		
		private string CodeHill(string[] arr_huruf,int[,] matrik,string plain_text)
		{
			try{
				Console.WriteLine();
				plain_text = plain_text.Replace(" ","");				
				string hasil = "",hasil_numberic = "";
				txt_chiper.Text += "Plaint text dibagi menjadi "+(txt_plaintext.Text.Length/int.Parse(txt_kolom.Text))+" bagian.\r\n\r\n";
				for(int i = 0; i<(plain_text.Length/int.Parse(txt_kolom.Text)); i++){
					txt_chiper.Text += "Bagian ke "+(i+1)+"\r\n\r\n";
					string text_split = plain_text.Substring(i*int.Parse(txt_kolom.Text),int.Parse(txt_kolom.Text));
					for(int m = 0; m<int.Parse(txt_baris.Text); m++){
						int tempo = 0;
						for(int n = 0; n<int.Parse(txt_kolom.Text); n++){
							tempo += (GetIndexHuruf(arr_huruf,text_split[n].ToString())*matrik[m,n]);	
							txt_chiper.Text += "huruf "+text_split[n].ToString().ToUpper()+" ("+GetIndexHuruf(arr_huruf,text_split[n].ToString())+") * "+matrik[m,n]+" = "+(GetIndexHuruf(arr_huruf,text_split[n].ToString())*matrik[m,n]+"\r\n");
						}
						txt_chiper.Text += "\r\n"+tempo+" di modulus 26 = "+(tempo%26)+"\r\n\r\n";
						hasil_numberic += (tempo%26)+" ";
						hasil += arr_huruf[(tempo%26)];
					}
					txt_chiper.Text += "\n\n";
				}
				txt_chiper.Text += "hasil numberic : "+hasil_numberic+"\r\n";
				txt_chiper.Text += "hasil alphabetic : "+hasil+"\r\n\r\n";
				return Vigenere(arr_huruf,hasil);
			}catch(Exception){
				return null;
			}
		}
		
		private string Vigenere(string[] arr_huruf,string plaint_text){
			try{
				txt_chiper.Text += "Proses Enkripsi Vigenere\r\n\r\n";
				
				byte i = 0;
				int p = 0;
				int k = 0;
				int res = 0;
				string hasil = "",hasil_number = "";
				foreach(char word in plaint_text){
					if(word.ToString() != " "){
						p = GetIndexHuruf(arr_huruf,word.ToString());
						k = GetIndexHuruf(arr_huruf,txt_key_vigenere.Text[i].ToString());
						res = (p+k)%26;
						txt_chiper.Text += "( "+word.ToString()+"("+p+") + "+txt_key_vigenere.Text[i]+"("+k+")) % 26 = "+res+" ("+arr_huruf[res]+")\r\n";
						hasil += arr_huruf[res];
						hasil_number += res+" ";
						i++;
						if(i >= txt_key_vigenere.Text.Length){
							i =0;
						}
					}else{
						hasil += " ";
					}				
				}
				txt_chiper.Text += "\r\nHasil Numberic : "+hasil_number;
				txt_chiper.Text += "\r\nHasil Alphabetic : "+hasil;
				txt_chiper.Text += "\r\n\r\nEND";
				button3.Focus();
				MessageBox.Show("enkripsi suksesss....","Rizal Afani say : ");
				return hasil;
			}catch(Exception){
				return null;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			try{
				txt_plaintext.Clear();
				txt_baris.Clear();
				txt_kolom.Clear();
				txt_matrik.Clear();
				txt_key_vigenere.Clear();
				txt_chiper.Clear();
			}catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			try{
				Clipboard.SetText(txt_chiper.Text);
			}catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://calonpresident.blogspot.com/");
		}
	}
}
