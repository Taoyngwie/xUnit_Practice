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
            //Assert. //������㹡�������ʹ��������
            Assert.Equal(11,result); //���������ҡѹ�Ѻ 11 ���
        }

        [Fact]
        public void ValidateCalculatorAddMethod2Digits()
        {
            var result = Add(50,69);
            //Assert. //������㹡�������ʹ��������
            Assert.Equal(119,result); 
        }

        [Fact]
        public void ValidateCalculatorAddMethod3Digits() //������ҧ�ѹ���Դ
        {
            var result = Add(500,600);
            //Assert. //������㹡�������ʹ��������
            Assert.Equal(1100,result); 
        }

        public int Add(int a,int b){
            return a + b;
        }
        

        [Theory] //����ö�Ѻ parameter ŧ�� method
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


        //�ʴ���÷ӧҹẺ����¹�������ʹ ��� Fact ���������ҧ��� 
        [Fact(DisplayName=("check add 3 digits."))]
        public void ValidateCalculatorAddMethod3Digits()
        {
            var result = Add(5,6);
            //Assert. //������㹡�������ʹ��������
            Assert.Equal(0,result); //���������ҡѹ�Ѻ 11 ���
        }
        [Theory(DisplayName=("check add method of my calculator."))] //����ö�Ѻ parameter ŧ�� method
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
