using System.Collections.Generic;
using System;

namespace MathString
{
    public class Calculation
    {
        private int ctoi(char c){return int.Parse(c.ToString());}
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
            string value ="";
            if(date1.Length==date2.Length){
                int hl = 0;//0 =,1 high,2 low
                for(int i =date1.Length;i>=0;i--){
                    if(int.Parse(date1[i].ToString())==int.Parse(date2[i].ToString())){
                        if(int.Parse(date1[i].ToString())>int.Parse(date2[i].ToString())){
                            hl=1;
                            break;
                        }else if(int.Parse(date1[i].ToString())<int.Parse(date2[i].ToString())){
                            hl=2;
                            break;
                        }
                    }
                }
                char[] d1 = date1.ToCharArray(),d2 = date2.ToCharArray();
                string[] d3 = new string[d1.Length];
                if(hl==1){
                    for(int i=0;i<date1.Length;i++){
                        d3[i] = $"{ctoi(d1[i])-ctoi(d2[i])}";
                    }
                    value = d3.ToString();
                }else if(hl==2){
                    for(int i=0;i<date1.Length;i++){
                        d3[i] = $"{ctoi(d2[i])-ctoi(d1[i])}";
                    }
                    value = d3.ToString();
                }else{
                    value="0";
                }
            }else if(date1.Length>date2.Length){
                int sa = date1.Length-date2.Length;
                char[] d1 = date1.ToCharArray(),d2 = date2.ToCharArray();
                string[] d3 = new string[d1.Length];
                d1=date1.ToCharArray();
                for(int i = 0;i<date1.Length;i++){
                    if(sa-1<=i){
                        d2[i] ='0';
                    }else{
                        d2[i] = date2.ToCharArray()[i];
                    }
                }
                for(int i=0;i<date1.Length;i++){
                        d3[i] = $"{ctoi(d1[i])-ctoi(d2[i])}";
                    }
                    value = d3.ToString();
            }else if(date1.Length<date2.Length){
                int sa = date2.Length-date1.Length;
                char[] d1 = date1.ToCharArray(),d2 = date2.ToCharArray();
                string[] d3 = new string[d1.Length];
                d2=date2.ToCharArray();
                for(int i =0;i<date2.Length;i++){
                    if(sa-1<=i){
                        d1[i] = '0';
                    }
                    else{
                        d1[i] = date1.ToCharArray()[i];
                    }
                }
                for(int i=0;i<date1.Length;i++){
                        d3[i] = $"{ctoi(d2[i])-ctoi(d1[i])}";
                    }
                    value = d3.ToString();
            }
            return value;
        }
        public string Multiplication(string date1,string date2){
            string value="";
            char[] _d1 = date1.ToCharArray(),_d2 =date2.ToCharArray();
            char[] d1 = new char[date1.Length],d2 = new char[date2.Length];
            for(int i = _d1.Length-1;i>=0;i--){
                d1[(_d1.Length-1)-i] = _d1[i];
            }
            for(int i = _d2.Length-1;i>=0;i--){
                d2[(_d2.Length-1)-i] = _d2[i];
            }
            List<string> d3 = new List<string>();
            string z = "";
            for(int i =0;i<d2.Length;i++){
                z="";
                for(int p = 0;p<i;p++){
                    z+="0";
                }
                List<string> d4 = new List<string>();
                string az = "";
                for(int v =0;v<d1.Length;v++){
                    for(int p = 0;p<i;p++){
                        az+="0";
                    }
                    d4.Add((ctoi(d1[v])*ctoi(d2[i])).ToString()+az);
                }
                for(int n =0;n<d4.Count;n++){
                    if(n!=0){
                        d3[i]+=Add(d3[i],d4[n]);
                    }
                    else{
                        d3.Add(d4[n]);
                    }
                }
                d3[i]+=z;
            }
            for(int i =0;i<d3.Count-1;i++){
                value=Add(value,d3[i]);
            }
            return value;
        }
    }
}