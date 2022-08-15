using System;
using Xunit;

namespace demoxunit
{
    public class UnitTest1
    {
        /*
        [Fact]
        public void ValidateCalculatorAddMethod()
        {
            var result = Add(5,6);
            //Assert. //เพื่อใช้ในการหาเมธอดเอาไว้เทส
            Assert.Equal(11,result); //เช็คว่าได้เท่ากันกับ 11 ไหม
        }

        [Fact]
        public void ValidateCalculatorAddMethod2Digits()
        {
            var result = Add(50,69);
            //Assert. //เพื่อใช้ในการหาเมธอดเอาไว้เทส
            Assert.Equal(119,result); 
        }

        [Fact]
        public void ValidateCalculatorAddMethod3Digits() //ตัวอย่างอันที่ผิด
        {
            var result = Add(500,600);
            //Assert. //เพื่อใช้ในการหาเมธอดเอาไว้เทส
            Assert.Equal(1100,result); 
        }

        public int Add(int a,int b){
            return a + b;
        }
        

        [Theory] //สามารถรับ parameter ลงไปใน method
        [InlineData(5,6,11)]
        [InlineData(50,69,119)]
        [InlineData(500,600,1100)]
        public void ValidateCalculatorAddMethod(int first,int second,int expected){
            var result = Add(first,second);
            Assert.Equal(expected,result);
        }

        public int Add(int a,int b){
            return a + b;
        }
        */


        //แสดงการทำงานแบบเปลี่ยนช่ือเมธอด ให้ Fact กลายเป็นอย่างอื่น 
        [Fact(DisplayName=("check add 3 digits."))]
        public void ValidateCalculatorAddMethod3Digits()
        {
            var result = Add(5,6);
            //Assert. //เพื่อใช้ในการหาเมธอดเอาไว้เทส
            Assert.Equal(0,result); //เช็คว่าได้เท่ากันกับ 11 ไหม
        }
        [Theory(DisplayName=("check add method of my calculator."))] //สามารถรับ parameter ลงไปใน method
        [InlineData(5,6,11)]
        [InlineData(50,69,119)]
        [InlineData(500,600,0)]
        public void ValidateCalculatorAddMethod(int first,int second,int expected){
            var result = Add(first,second);
            Assert.Equal(expected,result);
        }

        public int Add(int a,int b){
            return a + b;
        }

    }
}
