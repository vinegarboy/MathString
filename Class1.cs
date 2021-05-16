using Microsoft.VisualBasic.CompilerServices;
using System.Linq;
using System.Collections.Generic;
using System;

namespace MathString
{
    public class Calculation
    {
        public string Add(string date1,string date2){
            string ab = "";
            char[] _sd1 = date1.ToCharArray(),_sd2 = date2.ToCharArray(),_d1= new char[_sd1.Length],_d2= new char[_sd2.Length];
            for(int i = 0;i<_sd1.Length;i++){
                _d1[i] = _sd1[_sd1.Length-(i+1)];
            }
            for(int i =0;i<_sd2.Length;i++){
                _d2[i] = _sd2[_sd2.Length-(i+1)];
            }
            if(_d1.Length==_d2.Length){
                int v = 0,ib=0;
                string[] date = new string[_d1.Length];
                for(int i = 0;i<_d1.Length;i++){
                    ib=0;
                    if(v==0){
                        ib = int.Parse(_d1[i].ToString())+int.Parse(_d2[i].ToString());
                    }else{
                        ib=int.Parse(_d1[i].ToString())+int.Parse(_d2[i].ToString())+1;
                        v=0;
                    }
                    if(ib>10){
                        v+=1;
                        ib-=10;
                    }
                    date[i] = ib.ToString();
                }
                for(int i=date.Length-1;i>=0;i--){
                    ab+=date[i];
                }
            }else if(_d1.Length>_d2.Length){
                string[] date = new string[_d1.Length];
                int v = 0,ib=0;
                for(int i = 0;i<_d1.Length;i++){
                    ib=0;
                    if(i>=_d2.Length){
                        if(v==0){
                            ib = int.Parse(_d1[i].ToString());
                        }else{
                            ib=int.Parse(_d1[i].ToString())+1;
                            v=0;
                        }
                        if(ib>10){
                            v+=1;
                            ib-=10;
                        }
                        date[i] = ib.ToString();
                    }else{
                        if(v==0){
                            ib = int.Parse(_d1[i].ToString())+int.Parse(_d2[i].ToString());
                        }else{
                            ib=int.Parse(_d1[i].ToString())+int.Parse(_d2[i].ToString())+1;
                            v=0;
                        }
                        if(ib>10){
                            v+=1;
                            ib-=10;
                        }
                        date[i] = ib.ToString();
                    }
                }
                for(int i=date.Length-1;i>=0;i--){
                    ab+=date[i];
                }
            }else if(_d1.Length<_d2.Length){
                string[] date = new string[_d2.Length];
                int v = 0,ib=0;
                for(int i = 0;i<_d2.Length;i++){
                    v=0;
                    ib=0;
                    if(i>=_d1.Length){
                        if(v==0){
                            ib =int.Parse(_d2[i].ToString());
                        }else{
                            ib=int.Parse(_d2[i].ToString())+1;
                            v=0;
                        }
                        if(ib>10){
                            v+=1;
                            ib-=10;
                        }
                        date[i] = ib.ToString();
                    }else{
                        if(v==0){
                            ib = int.Parse(_d1[i].ToString())+int.Parse(_d2[i].ToString());
                        }else{
                            ib=int.Parse(_d1[i].ToString())+int.Parse(_d2[i].ToString())+1;
                            v=0;
                        }
                        if(ib>10){
                            v+=1;
                            ib-=10;
                        }
                        date[i] = ib.ToString();
                    }
                }
                for(int i=date.Length-1;i>=0;i--){
                    ab+=date[i];
                }
            }
            return ab;
        }
        public string Subtraction(string date1,string date2){
            string value="";
            char[] d1=date1.ToCharArray(),d2=date2.ToCharArray();
            if(d1.Length==d2.Length){
                int hl =0;
                for(int i =0;i<d1.Length;i++){
                    if(Convert.ToInt32(d1[i])>Convert.ToInt32(d2[i])){
                        hl=1;
                        break;
                    }else if(Convert.ToInt32(d1[i])<Convert.ToInt32(d2[i])){
                        hl=2;
                        break;
                    }
                }
                Array.Reverse(d1);
                Array.Reverse(d2);
                char[] d3 = new char[d1.Length];
                for(int i = 0;i<d3.Length;i++){
                    d3[i] = '0';
                }
                if(hl==0){
                    value="0";
                }else if(hl==1){
                    bool stack = false;
                    int date3 = 0;
                    for(int i=0;i<d1.Length;i++){
                        date3 = 0;
                        if(!stack){
                            date3 = Convert.ToInt32(d1[i].ToString())-Convert.ToInt32(d2[i].ToString());
                        }
                        else{
                            date3 = (Convert.ToInt32(d1[i].ToString())-1)-Convert.ToInt32(d2[i].ToString());
                            stack = false;
                        }
                        if(0>date3){
                            stack=true;
                            date3+=10;
                        }
                        d3[i] = Convert.ToChar(date3.ToString());
                    }
                    Array.Reverse(d3);
                    for(int i =0;i<d3.Length;i++){
                        if(d3[i]=='0'){
                            d3[i] = 'X';
                        }
                        else{
                            break;
                        }
                    }
                    value = new string(d3);
                }else{
                    bool stack = false;
                    int date3 = 0;
                    for(int i=0;i<d1.Length;i++){
                        date3 = 0;
                        if(!stack){
                            date3 = Convert.ToInt32(d2[i].ToString())-Convert.ToInt32(d1[i].ToString());
                        }
                        else{
                            date3 = (Convert.ToInt32(d2[i].ToString())-1)-Convert.ToInt32(d1[i].ToString());
                            stack = false;
                        }
                        if(0>date3){
                            stack=true;
                            date3+=10;
                        }
                        d3[i] = Convert.ToChar(date3.ToString());
                    }
                    Array.Reverse(d3);
                    for(int i =0;i<d3.Length;i++){
                        if(d3[i]=='0'){
                            d3[i] = 'X';
                        }
                        else{
                            break;
                        }
                    }
                    value = "-"+new string(d3);
                }
            }
            if(d1.Length>d2.Length){
                Array.Reverse(d1);
                Array.Reverse(d2);
                char[] d3 = new char[d1.Length];
                bool stack = false;
                int date3 = 0;
                for(int i = 0;i<d1.Length;i++){
                    date3 = 0;
                    if(i<d2.Length){
                        if(!stack){
                            date3 = Convert.ToInt32(d1[i].ToString())-Convert.ToInt32(d2[i].ToString());
                        }
                        else{
                            date3 = (Convert.ToInt32(d1[i].ToString())-1)-Convert.ToInt32(d2[i].ToString());
                            stack = false;
                        }
                        if(0>date3){
                            stack=true;
                            date3+=10;
                        }
                    }else{
                        if(!stack){
                            date3 = Convert.ToInt32(d1[i].ToString());
                        }
                        else{
                            date3 = (Convert.ToInt32(d1[i].ToString())-1);
                            stack = false;
                        }
                        if(0>date3){
                            stack=true;
                            date3+=10;
                        }
                    }
                    d3[i] = Convert.ToChar(date3.ToString());
                }
                Array.Reverse(d3);
                for(int i =0;i<d3.Length;i++){
                        if(d3[i]=='0'){
                            d3[i] = 'X';
                        }
                        else{
                            break;
                        }
                    }
                value = new string(d3);
            }
            if(d1.Length<d2.Length){
                Array.Reverse(d1);
                Array.Reverse(d2);
                bool stack = false;
                char[] d3 = new char[d2.Length];
                int date3 = 0;
                for(int i=0;i<d2.Length;i++){
                    date3 = 0;
                    if(i<d1.Length){
                        if(!stack){
                            date3 = Convert.ToInt32(d2[i].ToString())-Convert.ToInt32(d1[i].ToString());
                        }
                        else{
                            date3 = (Convert.ToInt32(d2[i].ToString())-1)-Convert.ToInt32(d1[i].ToString());
                            stack = false;
                        }
                        if(0>date3){
                            stack=true;
                            date3+=10;
                        }
                    }else{
                        if(!stack){
                            date3 = Convert.ToInt32(d2[i].ToString());
                        }
                        else{
                            date3 = (Convert.ToInt32(d2[i].ToString())-1);
                            stack = false;
                        }
                        if(0>date3){
                            stack=true;
                            date3+=10;
                        }
                    }
                    d3[i] = Convert.ToChar(date3.ToString());
                }
                Array.Reverse(d3);
                for(int i =0;i<d3.Length;i++){
                        if(d3[i]=='0'){
                            d3[i] = 'X';
                        }
                        else{
                            break;
                        }
                    }
                value = "-"+new string(d3);
            }
            value = value.Replace("X","");
            return value;
        }
        public string Multiplication(string date1,string date2){
            char[] d1 = date1.ToCharArray(),d2 = date2.ToCharArray();
            string value="0";
            Array.Reverse(d1);
            Array.Reverse(d2);
            int c=0;
            string[] date3 = new string[d1.Length*d2.Length];
            string gx ="";
            for(int i=0;i<d1.Length;i++){
                for(int b = 0;b<d2.Length;b++){
                    gx="";
                    for(int g=0;g<i+b;g++){
                        gx+="0";
                    }
                    date3[c] = (Convert.ToInt32(d1[i].ToString())*Convert.ToInt32(d2[b].ToString())).ToString()+gx;
                    c++;
                }
            }
            for(int i=0;i<date3.Length;i++){
                value = this.Add(value,date3[i]);
            }
            return value;
        }
        public string Division(string date1,string date2){
            char[] d1=date1.ToCharArray(),d2=date2.ToCharArray();
            bool che = false,ama=false,ama2=false;
            int _ama=0,_ama2=0;
            while(!che){
                if(int.Parse(d1[d1.Length-1].ToString())%2==0&&int.Parse(d2[d2.Length-1].ToString())%2==0){
                    for(int i = 0;i<d1.Length;i++){
                        if(!ama){
                            if(int.Parse(d1[i].ToString())%2!=0){
                                ama=true;
                                _ama=int.Parse(d1[i].ToString())%2;
                            }
                            d1[i] = Convert.ToChar((int.Parse(d1[i].ToString())/2).ToString());
                        }else{
                            if((int.Parse(d1[i].ToString())+(_ama*10))%2!=0){
                                ama=true;
                                _ama=(int.Parse(d1[i].ToString())+(_ama*10))%2;
                            }else{
                                ama=false;
                            }
                            d1[i] = Convert.ToChar(((int.Parse(d1[i].ToString())+(_ama*10))/2).ToString());
                            if(ama){
                                _ama=0;
                            }
                        }
                    }
                    for(int i = 0;i<d2.Length;i++){
                        if(!ama2){
                            if(int.Parse(d2[i].ToString())%2!=0){
                                ama2=true;
                                _ama2=int.Parse(d2[i].ToString())%2;
                            }
                            d2[i] = Convert.ToChar((int.Parse(d2[i].ToString())/2).ToString());
                        }else{
                            if((int.Parse(d2[i].ToString())+(_ama2*10))%2!=0){
                                ama2=true;
                                _ama2=(int.Parse(d2[i].ToString())+(_ama2*10))%2;
                            }else{
                                ama2=false;
                            }
                            d2[i] = Convert.ToChar(((int.Parse(d2[i].ToString())+(_ama2*10))/2).ToString());
                            if(ama2){
                                _ama2=0;
                            }
                        }
                    }
                }else{
                    che=true;
                }
            }
        }
    }
}