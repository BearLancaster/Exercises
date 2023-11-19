package org.example;

public class Main {
    public static void main(String[] args) {

//        String map="Ep01.mp4";
//        List<String> collect=new ArrayList<>();
//        collect.add(map);
//        map="at02.mp4";
//        collect.add(map);
//        map="St03.mp4";
//        collect.add(map);
//        List<String> Temp=new ArrayList<>();
//        String []list_1=new String[collect.size()];
//        int []list_2=new int[collect.size()];
//        int i=0;
//        for(String file:collect)
//        {
//
//            String temp_file=file.replace(".MP4","").replace(".mp4","");
//            String REGEX = "[^0-9]";
//
//            String ticket = Pattern.compile(REGEX).matcher(temp_file).replaceAll("").trim();
//
//            if(ticket.charAt(0)=='0')
//            {
//                ticket=ticket.substring(1);
//            }
//            list_1[i]=file;
//            list_2[i]=Integer.valueOf(ticket);
//            i++;
//        }
//        int temp;
//        String temp_string;
//        for (int d = 0; d < list_2.length; d++)
//        {
//            for (int j = d+1; j < list_2.length; j++) {
//                if (list_2[d] > list_2[j]) {
//
//                    temp = list_2[d];
//                    temp_string=list_1[d];
//                    list_2[d] = list_2[j];
//                    list_1[d]=list_1[j];
//                    list_2[j] = temp;
//                    list_1[j]=temp_string;
//                }
//            }
//        }
//        List<String> Sec_list=new ArrayList<>();
//        for(String fileName:list_1)
//        {
//            Sec_list.add(fileName);
//        }
//        for (String name:Sec_list)
//        {
//            System.out.println(name);
//        }


        String test="0101108020264";
        long tickit=Long.valueOf(test);
        System.out.println(tickit);
    }
}