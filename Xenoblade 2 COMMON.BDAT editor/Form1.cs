using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xenoblade_2_COMMON.BDAT_editor;

namespace Xenoblade_2_COMMON.BDAT_editor
{
    public partial class Form1 : Form
    {
        List<CHR_BL> cHR_BLs = new List<CHR_BL>();
        List<int[]> resourceCapacity = new List<int[]>();
        Stream openedFile;
        MemoryStream modifiedStream;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (openedFile = openFileDialog1.OpenFile())
                    {
                        if (!new CheckFile().ValidateFile(openedFile))
                            MessageBox.Show("Something is wrong with your file.");
                        else
                        {
                            openedFile.Seek(0, SeekOrigin.Begin);
                            modifiedStream = new MemoryStream();
                            openedFile.CopyTo(modifiedStream);


                            int initialBdatOffset = 819412;
                            int initialOffset = 822100;
                                                           //0 //1  //2 //3 //4//5//6 //7 //8//9//10//11//12//13
                            resourceCapacity.Add(new int[] { 9,  11, 11, 11,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1001
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1002
                            resourceCapacity.Add(new int[] { 15, 11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 0 }); //1003
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1004
                            resourceCapacity.Add(new int[] { 8,  11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1005  
                            resourceCapacity.Add(new int[] { 8,  11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1006  
                            resourceCapacity.Add(new int[] { 8,  11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1007  
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1008  
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 20, 11, 0, 7, 7, 6, 6, 8 }); //1009  
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 8 }); //1010  
                            resourceCapacity.Add(new int[] { 21, 11,  0,  0,  2, 0, 13, 11, 0, 7, 7, 6, 6, 8 }); //1011  
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  0, 0, 0 , 11, 0, 7, 7, 6, 0, 8 }); //1012  
                            resourceCapacity.Add(new int[] { 18, 11,  0,  0,  0, 0, 0 , 11, 0, 7, 7, 6, 0, 8 }); //1013  
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 8 }); //1014  
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 8 }); //1015  
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 18, 11, 0, 7, 7, 6, 6, 8 }); //1016  
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1017  
                            resourceCapacity.Add(new int[] { 6,  11,  0,  0,  2, 0, 18, 11, 0, 7, 7, 6, 6, 8 }); //1018 
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 18, 11, 0, 7, 7, 6, 6, 8 }); //1019
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 14, 11, 0, 7, 7, 6, 6, 8 }); //1020 
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1021 
                            resourceCapacity.Add(new int[] { 16, 11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1022
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1023  
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 18, 11, 0, 7, 7, 6, 6, 8 }); //1024 
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 8 }); //1025
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1026 
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1027 
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 15, 11, 0, 5,12, 6, 6, 8 }); //1028
                            resourceCapacity.Add(new int[] { 15, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 8 }); //1029
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1030
                            resourceCapacity.Add(new int[] { 6,  11,  0,  0,  2, 0, 13, 11, 0, 7, 7, 6, 6, 8 }); //1031
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 8 }); //1032
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1033
                            resourceCapacity.Add(new int[] { 6,  11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 8 }); //1034
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 8 }); //1035
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 17, 11, 0, 7, 7, 6, 6, 8 }); //1036
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 8 }); //1037
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1038
                            resourceCapacity.Add(new int[] { 7,  11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1039
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 18, 11, 0, 7, 7, 6, 6, 8 }); //1040
                            resourceCapacity.Add(new int[] { 6,  11,  0,  0,  2, 0, 18, 11, 0, 7, 7, 6, 6, 8 }); //1041
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 18, 11, 0, 7, 7, 6, 6, 8 }); //1042
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 20, 11, 0, 7, 7, 6, 6, 8 }); //1043
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 8 }); //1044
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 18, 11, 0, 7, 7, 6, 6, 8 }); //1045
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 8 }); //1046
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 8 }); //1047
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 17, 11, 0, 7, 7, 6, 6, 8 }); //1048
                            resourceCapacity.Add(new int[] { 24, 11,  0,  0,  2, 0, 18, 11, 0, 7, 7, 6, 6, 8 }); //1049
                            resourceCapacity.Add(new int[] { 16, 11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 0 }); //1050
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1051
                            resourceCapacity.Add(new int[] { 21, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1052
                            resourceCapacity.Add(new int[] { 36, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1053
                            resourceCapacity.Add(new int[] { 36, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1054
                            resourceCapacity.Add(new int[] { 21, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1055
                            resourceCapacity.Add(new int[] { 30, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1056
                            resourceCapacity.Add(new int[] { 33, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1057
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1058
                            resourceCapacity.Add(new int[] { 21, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1059
                            resourceCapacity.Add(new int[] { 36, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1060
                            resourceCapacity.Add(new int[] { 36, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1061
                            resourceCapacity.Add(new int[] { 21, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1062
                            resourceCapacity.Add(new int[] { 30, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1063
                            resourceCapacity.Add(new int[] { 33, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1064
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1065
                            resourceCapacity.Add(new int[] { 21, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1066
                            resourceCapacity.Add(new int[] { 36, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1067
                            resourceCapacity.Add(new int[] { 36, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1068
                            resourceCapacity.Add(new int[] { 21, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1069
                            resourceCapacity.Add(new int[] { 30, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1070
                            resourceCapacity.Add(new int[] { 33, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1071
                            resourceCapacity.Add(new int[] { 33, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1072
                            resourceCapacity.Add(new int[] { 26, 11,  0,  0,  0, 0,  0, 11, 0, 0, 0, 6, 6, 0 }); //1073
                            resourceCapacity.Add(new int[] { 36, 11,  0,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 0 }); //1074
                            resourceCapacity.Add(new int[] { 24, 11, 11,  0,  2, 0, 16, 11, 0, 7, 7, 6, 6, 0 }); //1075
                            resourceCapacity.Add(new int[] { 24, 11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 0 }); //1076
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 18, 11, 0, 7, 7, 6, 6, 0 }); //1077
                            resourceCapacity.Add(new int[] { 24, 11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 0 }); //1078
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 0 }); //1079
                            resourceCapacity.Add(new int[] { 9,  11,  0,  0,  2, 0, 15, 11, 0, 7, 7, 6, 6, 0 }); //1080
                            resourceCapacity.Add(new int[] { 12, 11,  0,  0,  2, 0, 17, 11, 0, 7, 7, 6, 6, 0 }); //1081
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1082
                            resourceCapacity.Add(new int[] { 33, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1083
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1084
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1085
                            resourceCapacity.Add(new int[] { 33, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1086
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1087
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1088
                            resourceCapacity.Add(new int[] { 33, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1089
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1090
                            resourceCapacity.Add(new int[] { 39, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1091
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1092
                            resourceCapacity.Add(new int[] { 33, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1093
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1094
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1095
                            resourceCapacity.Add(new int[] { 33, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1096
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1097
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1098
                            resourceCapacity.Add(new int[] { 33, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1099
                            resourceCapacity.Add(new int[] { 27, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1100
                            resourceCapacity.Add(new int[] { 39, 11,  0,  0,  2, 0, 19, 11, 0, 7, 7, 6, 6, 0 }); //1101
                            resourceCapacity.Add(new int[] { 36, 11,  0,  0,  2, 0, 18, 11, 0, 7, 7, 6, 6, 0 }); //1102
                            resourceCapacity.Add(new int[] { 24, 11,  1,  1,  2, 1, 20, 11, 1, 7, 7, 6, 6, 0 }); //1103
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 12, 11, 0, 7, 7, 6, 6, 8 }); //1104
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 19, 11, 0, 7, 7, 6, 6, 9 }); //1105
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 19, 11, 0, 7, 7, 6, 6, 9 }); //1106
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 20, 11, 0, 7, 7, 6, 6, 9 }); //1107
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 19, 11, 0, 7, 7, 6, 6, 9 }); //1108
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 19, 11, 0, 7, 7, 6, 6, 9 }); //1109
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  0, 0,  0, 11, 0, 7, 7, 0, 0, 0 }); //1110
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0,  0, 11, 0, 7, 7, 6, 6, 9 }); //1111
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0,  0, 11, 0, 7, 7, 6, 6, 9 }); //1112
                            resourceCapacity.Add(new int[] { 24,  0,  0,  0,  0, 0,  0,  0, 0, 0, 0, 0, 0, 0 }); //1113
                            resourceCapacity.Add(new int[] { 24,  0,  0,  0,  0, 0,  0,  0, 0, 0, 0, 0, 0, 0 }); //1114
                            resourceCapacity.Add(new int[] { 24,  0,  0,  0,  0, 0,  0,  0, 0, 0, 0, 0, 0, 0 }); //1115
                            resourceCapacity.Add(new int[] { 24,  0,  0,  0,  0, 0,  0,  0, 0, 0, 0, 0, 0, 0 }); //1116
                            resourceCapacity.Add(new int[] { 24,  0,  0,  0,  0, 0,  0,  0, 0, 0, 0, 0, 0, 0 }); //1117
                            resourceCapacity.Add(new int[] { 24,  0,  0,  0,  0, 0,  0,  0, 0, 0, 0, 0, 0, 0 }); //1118
                            resourceCapacity.Add(new int[] { 24,  0,  0,  0,  0, 0,  0,  0, 0, 0, 0, 0, 0, 0 }); //1119
                            resourceCapacity.Add(new int[] { 24,  0,  0,  0,  0, 0,  0,  0, 0, 0, 0, 0, 0, 0 }); //1120
                            resourceCapacity.Add(new int[] { 24,  0,  0,  0,  0, 0,  0,  0, 0, 0, 0, 0, 0, 0 }); //1121
                            resourceCapacity.Add(new int[] { 24,  0,  0,  0,  0, 0,  0,  0, 0, 0, 0, 0, 0, 0 }); //1122
                            resourceCapacity.Add(new int[] { 24,  0,  0,  0,  0, 0,  0,  0, 0, 0, 0, 0, 0, 0 }); //1123
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 19, 11, 0, 7, 7, 6, 6, 9 }); //1124
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 18, 11, 0, 7, 7, 6, 6, 9 }); //1125
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 18, 11, 0, 7, 7, 6, 6, 9 }); //1126
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 17, 11, 0, 7, 7, 6, 6, 9 }); //1127
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 20, 11, 0, 7, 7, 6, 6, 9 }); //1128
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 20, 11, 0, 7, 7, 6, 6, 9 }); //1129
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 21, 11, 0, 7, 7, 6, 6, 9 }); //1130
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 24, 11, 0, 7, 7, 6, 6, 9 }); //1131
                            resourceCapacity.Add(new int[] { 0,  11,  0,  0,  3, 0, 23, 11, 0, 7, 7, 6, 6, 9 }); //1132
                            for (int i = 0; i < listBox1.Items.Count; i++)      
                            {
                                CHR_BL cHR_BL = new CHR_BL().mapCHR_BL(openedFile, initialOffset, initialBdatOffset, resourceCapacity[i]);
                                cHR_BLs.Add(cHR_BL);
                                initialOffset = initialOffset + 244;
                            }


                            mainAplication.Enabled = true;
                            saveAsToolStripMenuItem.Enabled = true;
                            affectedCbox.SelectedIndex = 0;
                            fieldCbox.SelectedIndex = 0;

                            listBox1.SetSelected(00, true);
                        }
                    }
                }
                    catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int initialBdatOffset = 819412;
                    int initialOffset = 822100;
                    modifiedStream = new CHR_BL().injectCHR_BL(modifiedStream, cHR_BLs[0], initialOffset, initialBdatOffset);
                    File.WriteAllBytes(saveFileDialog1.FileName, modifiedStream.ToArray());
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapBlInterface(cHR_BLs, this.listBox1.SelectedIndex);
        }

        private void mapBlInterface(List<CHR_BL> cHR_BLs, int index)
        {
            nameID.Value = cHR_BLs[index].Name;
            nameIdBox.SelectedIndex = cHR_BLs[index].Name;
            debugNameBox.Text = cHR_BLs[index].DebugName;
            raceNbox.Value = cHR_BLs[index].Race;
            genderCbx.SelectedIndex = cHR_BLs[index].Gender;
            weaponNBox.Value = cHR_BLs[index].WeaponType;
            weaponCbox.SelectedIndex = cHR_BLs[index].WeaponType;
            elementNbox.Value = cHR_BLs[index].Atr;
            elementCbox.SelectedIndex = cHR_BLs[index].Atr;
            coolTimeNbox.Value = cHR_BLs[index].CoolTime;
            stillNbox.Value = cHR_BLs[index].Still ?? 0;
            orbNbox.Value = cHR_BLs[index].OrbNum;
            conditionNbox.Value = cHR_BLs[index].Condition ?? 0;

            pDefNbox.Value = cHR_BLs[index].PArmor;
            eDefNbox.Value = cHR_BLs[index].EArmor;
            mHpNbox.Value = cHR_BLs[index].HpMaxRev;
            sModNbox.Value = cHR_BLs[index].StrengthRev;
            eModNbox.Value = cHR_BLs[index].PowEtherRev;
            dModNbox.Value = cHR_BLs[index].DexRev;
            agModNbox.Value = cHR_BLs[index].AgilityRev;
            lkModNbox.Value = cHR_BLs[index].LuckRev;

            braveryNbox.Value = cHR_BLs[index].IdeaBlue;
            truthNbox.Value = cHR_BLs[index].IdeaRed;
            compassionNbox.Value = cHR_BLs[index].IdeaWhite;
            justiceNbox.Value = cHR_BLs[index].IdeaBlack;

            cat1Nbox.Value = cHR_BLs[index].FavoriteCategory1;
            cat1Cbox.SelectedIndex = cHR_BLs[index].FavoriteCategory1;
            cat2Nbox.Value = cHR_BLs[index].FavoriteCategory2;
            cat2Cbox.SelectedIndex = cHR_BLs[index].FavoriteCategory2;
            item1Nbox.Value = cHR_BLs[index].FavoriteItem1 == 0 ? 40000 : cHR_BLs[index].FavoriteItem1;
            item1Cbox.SelectedIndex = cHR_BLs[index].FavoriteItem1 < 40000 ? cHR_BLs[index].FavoriteItem1 : cHR_BLs[index].FavoriteItem1 - 40000;
            item2Nbox.Value = cHR_BLs[index].FavoriteItem2 == 0 ? 40000 : cHR_BLs[index].FavoriteItem2;
            item2Cbox.SelectedIndex = cHR_BLs[index].FavoriteItem2 < 40000 ? cHR_BLs[index].FavoriteItem2 : cHR_BLs[index].FavoriteItem2 - 40000;

            art1Cbox.SelectedIndex = cHR_BLs[index].NArts1;
            art2Cbox.SelectedIndex = cHR_BLs[index].NArts2;
            art3Cbox.SelectedIndex = cHR_BLs[index].NArts3;
            art1Nbox.Value = cHR_BLs[index].NArts1;
            art2Nbox.Value = cHR_BLs[index].NArts2;
            art3Nbox.Value = cHR_BLs[index].NArts3;

            bs1Cbox.SelectedIndex = cHR_BLs[index].BSkill1;
            bs2Cbox.SelectedIndex = cHR_BLs[index].BSkill2;
            bs3Cbox.SelectedIndex = cHR_BLs[index].BSkill3;
            bs1Nbox.Value = cHR_BLs[index].BSkill1;
            bs2Nbox.Value = cHR_BLs[index].BSkill2;
            bs3Nbox.Value = cHR_BLs[index].BSkill3;

            fs1Cbox.SelectedIndex = cHR_BLs[index].FSkill1;
            fs2Cbox.SelectedIndex = cHR_BLs[index].FSkill2;
            fs3Cbox.SelectedIndex = cHR_BLs[index].FSkill3;
            fs1Nbox.Value = cHR_BLs[index].FSkill1;
            fs2Nbox.Value = cHR_BLs[index].FSkill2;
            fs3Nbox.Value = cHR_BLs[index].FSkill3;

            sp1Cbox.SelectedIndex = cHR_BLs[index].BArts1;
            sp2Cbox.SelectedIndex = cHR_BLs[index].BArts2;
            sp3Cbox.SelectedIndex = cHR_BLs[index].BArts3;
            sp4Cbox.SelectedIndex = cHR_BLs[index].BartsEx;
            spAlt4Cbox.SelectedIndex = cHR_BLs[index].BartsEx2;
            sp1Nbox.Value = cHR_BLs[index].BArts1;
            sp2Nbox.Value = cHR_BLs[index].BArts2;
            sp3Nbox.Value = cHR_BLs[index].BArts3;
            sp4Nbox.Value = cHR_BLs[index].BartsEx;
            spAlt4Nbox.Value = cHR_BLs[index].BartsEx2;

            modelBox.Text = cHR_BLs[index].Model;
            model2Box.Text = cHR_BLs[index].Model2;
            motionBox.Text = cHR_BLs[index].Motion;
            motion2Box.Text = cHR_BLs[index].Motion2;
            addMotionBox.Text = cHR_BLs[index].AddMotion;
            voiceCbox.Text = cHR_BLs[index].Voice;
            comEffCbox.Text = cHR_BLs[index].Com_Eff;
            sePackCbox.Text = cHR_BLs[index].SePack;
            mnuVCbox.Text = cHR_BLs[index].MnuVoice1;
            mnuV2Cbox.Text = cHR_BLs[index].MnuVoice2;
            mnuV3Cbox.Text = cHR_BLs[index].MnuVoice3;

            onlyWpn.Checked = cHR_BLs[index].OnlyWpn;
            noBuildWpn.Checked = cHR_BLs[index].NoBuildWpn;
            onlyChBtl.Checked = cHR_BLs[index].OnlyChBtl;
            freeEngage.Checked = cHR_BLs[index].FreeEngage;
            noMapRev.Checked = cHR_BLs[index].NoMapRev;
        }

        private void nameID_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].Name = Convert.ToInt32(nameID.Value); 
            nameIdBox.SelectedIndex = Convert.ToInt32(nameID.Value);
        }

        private void nameIdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].Name = nameIdBox.SelectedIndex;
            nameID.Value = nameIdBox.SelectedIndex;
        }

        private void raceNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].Race = Convert.ToInt32(raceNbox.Value);
        }

        private void coolTimeNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].CoolTime = Convert.ToInt32(coolTimeNbox.Value);
        }

        private void weaponNBox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].WeaponType = Convert.ToInt32(weaponNBox.Value);
            weaponCbox.SelectedIndex = Convert.ToInt32(weaponNBox.Value);
        }

        private void weaponCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].WeaponType = Convert.ToInt32(weaponCbox.SelectedIndex);
            weaponNBox.Value = Convert.ToInt32(weaponCbox.SelectedIndex);
        }

        private void elementNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].Atr = Convert.ToInt32(elementNbox.Value);
            elementCbox.SelectedIndex = Convert.ToInt32(elementNbox.Value);
        }

        private void elementCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].Atr = Convert.ToInt32(elementCbox.SelectedIndex);
            elementNbox.Value = Convert.ToInt32(elementCbox.SelectedIndex);
        }

        private void stillNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].Still = Convert.ToInt32(stillNbox.Value);
        }

        private void orbNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].OrbNum = Convert.ToInt32(orbNbox.Value);
        }

        private void conditionNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].Condition = Convert.ToInt32(conditionNbox.Value);
        }

        private void debugNameBox_TextChanged(object sender, EventArgs e)
        {
            //if(debugNameBox.Text != cHR_BLs[this.listBox1.SelectedIndex].DebugName)
            //    if (Encoding.UTF8.GetBytes(debugNameBox.Text).Length > resourceCapacity[this.listBox1.SelectedIndex][0])
            //    {
            //        MessageBox.Show("Try fewer characters. Be aware that some ideograms and symbols take up more space.");
            //        debugNameBox.Text = cHR_BLs[this.listBox1.SelectedIndex].DebugName;
            //    }
            //    else
            //    {
            //        cHR_BLs[this.listBox1.SelectedIndex].DebugName = debugNameBox.Text;
            //    }
        }

        private void pDefNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].PArmor = Convert.ToInt32(pDefNbox.Value);
        }

        private void eDefNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].EArmor = Convert.ToInt32(eDefNbox.Value);
        }

        private void mHpNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].HpMaxRev = Convert.ToInt32(mHpNbox.Value);
        }

        private void sModNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].StrengthRev = Convert.ToInt32(sModNbox.Value);
        }

        private void eModNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].PowEtherRev = Convert.ToInt32(eModNbox.Value);
        }

        private void dModNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].DexRev = Convert.ToInt32(dModNbox.Value);
        }

        private void agModNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].AgilityRev = Convert.ToInt32(agModNbox.Value);
        }

        private void lkModNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].LuckRev = Convert.ToInt32(lkModNbox.Value);
        }

        private void braveryNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].IdeaBlue = Convert.ToInt32(braveryNbox.Value);
        }

        private void truthNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].IdeaRed = Convert.ToInt32(truthNbox.Value);
        }

        private void compassionNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].IdeaWhite = Convert.ToInt32(compassionNbox.Value);
        }

        private void justiceNbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].IdeaBlack = Convert.ToInt32(justiceNbox.Value);
        }

        private void cat1Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FavoriteCategory1 = Convert.ToInt32(cat1Nbox.Value);
            cat1Cbox.SelectedIndex = Convert.ToInt32(cat1Nbox.Value);
        }

        private void cat2Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FavoriteCategory2 = Convert.ToInt32(cat2Nbox.Value);
            cat2Cbox.SelectedIndex = Convert.ToInt32(cat2Nbox.Value);
        }

        private void cat1Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FavoriteCategory1 = cat1Cbox.SelectedIndex;
            cat1Nbox.Value = cat1Cbox.SelectedIndex;
        }

        private void cat2Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FavoriteCategory2 = cat2Cbox.SelectedIndex;
            cat2Nbox.Value = cat2Cbox.SelectedIndex;
        }

        private void item1Nbox_ValueChanged(object sender, EventArgs e)
        {
            if (item1Nbox.Value == 0)
                item1Nbox.Value = 40000;
            cHR_BLs[this.listBox1.SelectedIndex].FavoriteItem1 = Convert.ToInt32(item1Nbox.Value) == 40000 ? 0 : Convert.ToInt32(item1Nbox.Value); 
            item1Cbox.SelectedIndex = Convert.ToInt32(item1Nbox.Value) - 40000;
        }

        private void item2Nbox_ValueChanged(object sender, EventArgs e)
        {
            if (item2Nbox.Value == 0)
                item2Nbox.Value = 40000;
            cHR_BLs[this.listBox1.SelectedIndex].FavoriteItem2 = Convert.ToInt32(item2Nbox.Value) == 40000 ? 0 : Convert.ToInt32(item2Nbox.Value); 
            item2Cbox.SelectedIndex = Convert.ToInt32(item2Nbox.Value) - 40000;
        }

        private void item1Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FavoriteItem1 = item1Cbox.SelectedIndex == 0 ? 0 : item1Cbox.SelectedIndex  + 40000;
            item1Nbox.Value = item1Cbox.SelectedIndex + 40000;
        }

        private void item2Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FavoriteItem2 = item2Cbox.SelectedIndex == 0 ? 0 : item2Cbox.SelectedIndex + 40000;
            item2Nbox.Value = item2Cbox.SelectedIndex + 40000;
        }

        private void art1Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].NArts1 = Convert.ToInt32(art1Nbox.Value);
            art1Cbox.SelectedIndex = Convert.ToInt32(art1Nbox.Value);
        }

        private void art2Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].NArts3 = Convert.ToInt32(art2Nbox.Value);
            art2Cbox.SelectedIndex = Convert.ToInt32(art2Nbox.Value);
        }

        private void art3Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].NArts3 = Convert.ToInt32(art3Nbox.Value);
            art3Cbox.SelectedIndex = Convert.ToInt32(art3Nbox.Value);
        }

        private void art1Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].NArts1 = art1Cbox.SelectedIndex;
            art1Nbox.Value = Convert.ToInt32(art1Cbox.SelectedIndex);
        }

        private void art2Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].NArts2 = art2Cbox.SelectedIndex;
            art2Nbox.Value = Convert.ToInt32(art2Cbox.SelectedIndex);
        }

        private void art3Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].NArts3 = art3Cbox.SelectedIndex;
            art3Nbox.Value = Convert.ToInt32(art3Cbox.SelectedIndex);
        }

        private void bs1Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BSkill1 = Convert.ToInt32(bs1Nbox.Value);
            bs1Cbox.SelectedIndex = Convert.ToInt32(bs1Nbox.Value);
        }

        private void bs2Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BSkill2 = Convert.ToInt32(bs2Nbox.Value);
            bs2Cbox.SelectedIndex = Convert.ToInt32(bs2Nbox.Value);
        }

        private void bs3Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BSkill3 = Convert.ToInt32(bs3Nbox.Value);
            bs3Cbox.SelectedIndex = Convert.ToInt32(bs3Nbox.Value);
        }

        private void bs1Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BSkill1 = bs1Cbox.SelectedIndex;
            bs1Nbox.Value = bs1Cbox.SelectedIndex;
        }

        private void bs2Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BSkill2 = bs2Cbox.SelectedIndex;
            bs2Nbox.Value = bs2Cbox.SelectedIndex;
        }

        private void bs3Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BSkill3 = bs3Cbox.SelectedIndex;
            bs3Nbox.Value = bs3Cbox.SelectedIndex;
        }

        private void fs1Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FSkill1 = Convert.ToInt32(fs1Nbox.Value);
            fs1Cbox.SelectedIndex = Convert.ToInt32(fs1Nbox.Value);
        }

        private void fs2Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FSkill2 = Convert.ToInt32(fs2Nbox.Value);
            fs2Cbox.SelectedIndex = Convert.ToInt32(fs2Nbox.Value);
        }

        private void fs3Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FSkill3 = Convert.ToInt32(fs3Nbox.Value);
            fs3Cbox.SelectedIndex = Convert.ToInt32(fs3Nbox.Value);
        }

        private void fs1Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FSkill1 = Convert.ToInt32(fs1Cbox.SelectedIndex);
            fs1Nbox.Value = Convert.ToInt32(fs1Cbox.SelectedIndex);
        }

        private void fs2Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FSkill2 = Convert.ToInt32(fs2Cbox.SelectedIndex);
            fs2Nbox.Value = Convert.ToInt32(fs2Cbox.SelectedIndex);
        }

        private void fs3Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FSkill3 = Convert.ToInt32(fs3Cbox.SelectedIndex);
            fs3Nbox.Value = Convert.ToInt32(fs3Cbox.SelectedIndex);
        }

        private void onlyWpn_CheckedChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].OnlyWpn = onlyWpn.Checked;
        }

        private void noBuildWpn_CheckedChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].NoBuildWpn = noBuildWpn.Checked;
        }

        private void onlyChBtl_CheckedChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].OnlyChBtl = onlyChBtl.Checked;
        }

        private void freeEngage_CheckedChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].FreeEngage = freeEngage.Checked;
        }

        private void noMapRev_CheckedChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].NoMapRev = noMapRev.Checked;
        }

        private void sp1Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BArts1 = sp1Cbox.SelectedIndex;
            sp1Nbox.Value = sp1Cbox.SelectedIndex;
        }

        private void sp1Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BArts1 = Convert.ToInt32(sp1Nbox.Value);
            sp1Cbox.SelectedIndex = Convert.ToInt32(sp1Nbox.Value);
        }

        private void sp2Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BArts2 = sp2Cbox.SelectedIndex;
            sp2Nbox.Value = sp2Cbox.SelectedIndex;
        }

        private void sp2Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BArts2 = Convert.ToInt32(sp2Nbox.Value);
            sp2Cbox.SelectedIndex = Convert.ToInt32(sp2Nbox.Value);
        }

        private void sp3Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BArts3 = sp3Cbox.SelectedIndex;
            sp3Nbox.Value = sp3Cbox.SelectedIndex;
        }
        private void sp3Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BArts3 = Convert.ToInt32(sp3Nbox.Value);
            sp3Cbox.SelectedIndex = Convert.ToInt32(sp3Nbox.Value);
        }

        private void sp4Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BartsEx = sp4Cbox.SelectedIndex;
            sp4Nbox.Value = sp4Cbox.SelectedIndex;
        }
        private void sp4Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BartsEx = Convert.ToInt32(sp4Nbox.Value);
            sp4Cbox.SelectedIndex = Convert.ToInt32(sp4Nbox.Value);
        }

        private void spAlt4Cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BartsEx2 = spAlt4Cbox.SelectedIndex;
            spAlt4Nbox.Value = spAlt4Cbox.SelectedIndex;
        }

        private void spAlt4Nbox_ValueChanged(object sender, EventArgs e)
        {
            cHR_BLs[this.listBox1.SelectedIndex].BartsEx = Convert.ToInt32(spAlt4Nbox.Value);
            spAlt4Cbox.SelectedIndex = Convert.ToInt32(spAlt4Nbox.Value);
        }

        private void affectedCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (affectedCbox.SelectedIndex)
            {
                case 0:
                    idCbox.Enabled = false;
                    break;
                case 1:
                    idCbox.Enabled = true;
                    break;
            }
        }

        private void fieldCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(fieldCbox.SelectedIndex > 91)
            {
                valueCbox.Enabled = false;
                enabled.Enabled = true;
            }
            else
            {
                valueCbox.Enabled = true;
                enabled.Enabled = false;
            }

            switch (fieldCbox.Text)
            {
                case "Name":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 108;
                    break;
                case "Race":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 10;
                    break;
                case "RotateLimitRoll":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "RotateLimitPitch":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "Gender":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 4;
                    break;
                case "QuestRace":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 2;
                    break;
                case "Still":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 447;
                    break;
                case "EyeRot":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "ChestHeight":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "LandingHeight":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "FootStep":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "FootStepEffect":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "WeaponType":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 36;
                    break;
                case "Scale":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "WpnScale":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "PrivateWpnR":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 339;
                    break;
                case "PrivateWpnL":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 339;
                    break;
                case "PrivateWpnRDriver":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 339;
                    break;
                case "PrivateWpnLDriver":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 339;
                    break;
                case "OrbNum":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "Atr":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 8;
                    break;
                case "Personality":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 96;
                    break;
                case "CoolTime":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "DefWeapon":
                    valueCbox.Minimum = 5001; valueCbox.Maximum = 6409;
                    break;
                case "BArts1":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 269;
                    break;
                case "BArts2":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 269;
                    break;
                case "BArts3":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 269;
                    break;
                case "BartsEx":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 134;
                    break;
                case "BartsEx2":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 134;
                    break;
                case "NArts1":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 35;
                    break;
                case "NArtsRecastRev":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "NArts2":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 35;
                    break;
                case "NArtsRecastRev2":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "NArts3":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 35;
                    break;
                case "NArtsRecastRev3":
                case "BSkill1":
                case "BSkill2":
                case "BSkill3":
                case "PArmor":
                case "EArmor":
                case "HpMaxRev":
                case "StrengthRev":
                case "PowEtherRev":
                case "DexRev":
                case "AgilityRev":
                case "LuckRev":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "BKLSet":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "FSkill1":
                case "FSkill2":
                case "FSkill3":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 74;
                    break;
                case "ArtsAchievement1":
                case "ArtsAchievement2":
                case "ArtsAchievement3":
                case "SkillAchievement1":
                case "SkillAchievement2":
                case "SkillAchievement3":
                case "FskillAchivement1":
                case "FskillAchivement2":
                case "FskillAchivement3":
                case "KeyAchievement":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 1768;
                    break;
                case "IdeaBlue":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "IdeaRed":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "IdeaWhite":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "IdeaBlack":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "FavoriteCategory1":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 23;
                    break;
                case "FavoriteItem1":
                    valueCbox.Minimum = 40000; valueCbox.Maximum = 40428;
                    break;
                case "FavoriteCategory2":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 23;
                    break;
                case "FavoriteItem2":
                    valueCbox.Minimum = 40000; valueCbox.Maximum = 40428;
                    break;
                case "CreateEventID":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "NormalTalk":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "CollisionId":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "BladeSize":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "MemorySlot":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 256;
                    break;
                case "EventAsset":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "MerceName":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "ReleaseLock":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 1;
                    break;
                case "CreateInfo":
                case "ExtraParts1":
                case "ExtraParts2":
                case "ExtraParts3":
                case "ExtraParts4":
                case "MnuCastName":
                case "MnuIlustName":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 65535;
                    break;
                case "sortJP":
                case "sortGE":
                case "sortFR":
                case "sortSP":
                case "sortIT":
                case "sortGB":
                case "sortCN":
                case "sortTW":
                    valueCbox.Minimum = 0; valueCbox.Maximum = 4294967295;
                    break;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (affectedCbox.SelectedIndex == 0)
                    {
                        foreach (CHR_BL cHR_BL in cHR_BLs)
                        {
                            advancedBladeMapping(fieldCbox.Text);
                            mapBlInterface(cHR_BLs, Convert.ToInt32(idCbox.Value));
                            idCbox.Value = idCbox.Value == 131 ? idCbox.Value : idCbox.Value + 1;
                        }
                        idCbox.Value = 0;
                    }
                    else
                    {
                        advancedBladeMapping(fieldCbox.Text);
                        mapBlInterface(cHR_BLs, Convert.ToInt32(idCbox.Value));
                    }
                    MessageBox.Show("Sucess!");
                }
                catch
                {
                    MessageBox.Show("Some error ocorred! Closing the application...");
                    Application.Exit();
                }
                
                
            }
        }
    
        private void advancedBladeMapping(string field)
        {
            switch (field)
            {
                case "Name":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].Name = Convert.ToInt32(valueCbox.Value);
                    break;
                case "Race":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].Race = Convert.ToInt32(valueCbox.Value);
                    break;
                case "RotateLimitRoll":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].RotateLimitRoll = Convert.ToInt32(valueCbox.Value);
                    break;
                case "RotateLimitPitch":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].RotateLimitPitch = Convert.ToInt32(valueCbox.Value);
                    break;
                case "Gender":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].Gender = Convert.ToInt32(valueCbox.Value);
                    break;
                case "QuestRace":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].QuestRace = Convert.ToInt32(valueCbox.Value);
                    break;
                case "Still":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].Still = Convert.ToInt32(valueCbox.Value);
                    break;
                case "EyeRot":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].EyeRot = Convert.ToInt32(valueCbox.Value);
                    break;
                case "ChestHeight":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].ChestHeight = Convert.ToInt32(valueCbox.Value);
                    break;
                case "LandingHeight":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].LandingHeight = Convert.ToInt32(valueCbox.Value);
                    break;
                case "FootStep":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FootStep = Convert.ToInt32(valueCbox.Value);
                    break;
                case "FootStepEffect":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FootStepEffect = Convert.ToInt32(valueCbox.Value);
                    break;
                case "WeaponType":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].WeaponType = Convert.ToInt32(valueCbox.Value);
                    break;
                case "Scale":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].Scale = Convert.ToInt32(valueCbox.Value);
                    break;
                case "WpnScale":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].WpnScale = Convert.ToInt32(valueCbox.Value);
                    break;
                case "PrivateWpnR":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].PrivateWpnR = Convert.ToInt32(valueCbox.Value);
                    break;
                case "PrivateWpnL":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].PrivateWpnL = Convert.ToInt32(valueCbox.Value);
                    break;
                case "PrivateWpnRDriver":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].PrivateWpnL_Driver = Convert.ToInt32(valueCbox.Value);
                    break;
                case "PrivateWpnLDriver":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].PrivateWpnR_Driver = Convert.ToInt32(valueCbox.Value);
                    break;
                case "OrbNum":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].OrbNum = Convert.ToInt32(valueCbox.Value);
                    break;
                case "Atr":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].Atr = Convert.ToInt32(valueCbox.Value);
                    break;
                case "Personality":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].Personality = Convert.ToInt32(valueCbox.Value);
                    break;
                case "CoolTime":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].CoolTime = Convert.ToInt32(valueCbox.Value);
                    break;
                case "DefWeapon":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].DefWeapon = Convert.ToInt32(valueCbox.Value);
                    break;
                case "BArts1":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].BArts1 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "BArts2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].BArts2 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "BArts3":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].BArts3 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "BartsEx":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].BartsEx = Convert.ToInt32(valueCbox.Value);
                    break;
                case "BartsEx2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].BartsEx2 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "NArts1":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].NArts1 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "NArtsRecastRev":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].NArtsRecastRev1 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "NArts2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].NArts2 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "NArtsRecastRev2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].NArtsRecastRev2 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "NArts3":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].NArts3 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "NArtsRecastRev3":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].NArtsRecastRev3 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "BSkill1":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].BSkill1 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "BSkill2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].BSkill2 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "BSkill3":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].BSkill3 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "PArmor":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].PArmor = Convert.ToInt32(valueCbox.Value);
                    break;
                case "EArmor":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].EArmor = Convert.ToInt32(valueCbox.Value);
                    break;
                case "HpMaxRev":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].HpMaxRev = Convert.ToInt32(valueCbox.Value);
                    break;
                case "StrengthRev":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].StrengthRev = Convert.ToInt32(valueCbox.Value);
                    break;
                case "PowEtherRev":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].PowEtherRev = Convert.ToInt32(valueCbox.Value);
                    break;
                case "DexRev":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].DexRev = Convert.ToInt32(valueCbox.Value);
                    break;
                case "AgilityRev":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].AgilityRev = Convert.ToInt32(valueCbox.Value);
                    break;
                case "LuckRev":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].LuckRev = Convert.ToInt32(valueCbox.Value);
                    break;
                case "BKLSet":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].BKLSet = Convert.ToInt32(valueCbox.Value);
                    break;
                case "FSkill1":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FSkill1 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "FSkill2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FSkill2 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "FSkill3":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FSkill3 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "ArtsAchievement1":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].ArtsAchievement1 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "ArtsAchievement2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].ArtsAchievement2 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "ArtsAchievement3":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].ArtsAchievement3 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "SkillAchievement1":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].SkillAchievement1 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "SkillAchievement2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].SkillAchievement2 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "SkillAchievement3":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].SkillAchievement3 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "FskillAchivement1":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FskillAchivement1 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "FskillAchivement2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FskillAchivement2 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "FskillAchivement3":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FskillAchivement3 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "KeyAchievement":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].KeyAchievement = Convert.ToInt32(valueCbox.Value);
                    break;
                case "IdeaBlue":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].IdeaBlue = Convert.ToInt32(valueCbox.Value);
                    break;
                case "IdeaRed":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].IdeaRed = Convert.ToInt32(valueCbox.Value);
                    break;
                case "IdeaWhite":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].IdeaWhite = Convert.ToInt32(valueCbox.Value);
                    break;
                case "IdeaBlack":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].IdeaBlack = Convert.ToInt32(valueCbox.Value);
                    break;
                case "FavoriteCategory1":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FavoriteCategory1 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "FavoriteItem1":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FavoriteItem1 = Convert.ToInt32(valueCbox.Value) == 40000 ? 0 : Convert.ToInt32(valueCbox.Value);
                    break;
                case "FavoriteCategory2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FavoriteCategory2 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "FavoriteItem2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FavoriteItem2 = Convert.ToInt32(valueCbox.Value) == 40000 ? 0 : Convert.ToInt32(valueCbox.Value);
                    break;
                case "CreateEventID":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].CreateEventID = Convert.ToInt32(valueCbox.Value);
                    break;
                case "NormalTalk":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].NormalTalk = Convert.ToInt32(valueCbox.Value);
                    break;
                case "CollisionId":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].CollisionId = Convert.ToInt32(valueCbox.Value);
                    break;
                case "BladeSize":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].BladeSize = Convert.ToInt32(valueCbox.Value);
                    break;
                case "MemorySlot":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].MemorySlot = Convert.ToInt32(valueCbox.Value);
                    break;
                case "EventAsset":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].EventAsset = Convert.ToInt32(valueCbox.Value);
                    break;
                case "MerceName":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].MerceName = Convert.ToInt32(valueCbox.Value);
                    break;
                case "ReleaseLock":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].ReleaseLock = Convert.ToInt32(valueCbox.Value);
                    break;
                case "CreateInfo":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].CreateInfo = Convert.ToInt32(valueCbox.Value);
                    break;
                case "ExtraParts1":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].ExtraParts1 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "ExtraParts2":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].ExtraParts2 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "ExtraParts3":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].ExtraParts3 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "ExtraParts4":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].ExtraParts4 = Convert.ToInt32(valueCbox.Value);
                    break;
                case "MnuCastName":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].MnuCastName = Convert.ToInt32(valueCbox.Value);
                    break;
                case "MnuIlustName":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].MnuIlustName = Convert.ToInt32(valueCbox.Value);
                    break;
                case "sortJP":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].sortJP = Convert.ToInt32(valueCbox.Value);
                    break;
                case "sortGE":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].sortGE = Convert.ToInt32(valueCbox.Value);
                    break;
                case "sortFR":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].sortFR = Convert.ToInt32(valueCbox.Value);
                    break;
                case "sortSP":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].sortSP = Convert.ToInt32(valueCbox.Value);
                    break;
                case "sortIT":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].sortIT = Convert.ToInt32(valueCbox.Value);
                    break;
                case "sortGB":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].sortGB = Convert.ToInt32(valueCbox.Value);
                    break;
                case "sortCN":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].sortCN = Convert.ToInt32(valueCbox.Value);
                    break;
                case "sortTW":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].sortTW = Convert.ToInt32(valueCbox.Value);
                    break;
                case "OnlyWpn":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].OnlyWpn = enabled.Checked;
                    break;
                case "NoBuildWpn":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].NoBuildWpn = enabled.Checked;
                    break;
                case "OnlyChBtl":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].OnlyChBtl = enabled.Checked;
                    break;
                case "FreeEngage":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].FreeEngage = enabled.Checked;
                    break;
                case "NoMapRev":
                    cHR_BLs[Convert.ToInt32(idCbox.Value)].NoMapRev = enabled.Checked;
                    break;
            }
        }
    }
}
