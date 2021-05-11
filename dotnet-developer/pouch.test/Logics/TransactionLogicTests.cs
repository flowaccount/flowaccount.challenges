using Flowaccount.Data;
using Flowaccount.Data.Handlers;
using Flowaccount.Data.Models;
using Flowaccount.Logic;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Xunit;

namespace api.test.Logics
{
    public class TransactionLogicTests
    {
        private MockRepository mockRepository;

        private Mock<ILogger<TransactionLogic>> mockLogger;
        private Mock<IRepository<Transactions>> mockTransactionRepository;

        public TransactionLogicTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockLogger = this.mockRepository.Create<ILogger<TransactionLogic>>();
            this.mockTransactionRepository = this.mockRepository.Create<IRepository<Transactions>>();
        }

        private TransactionLogic CreateTransactionLogic()
        {
            return new TransactionLogic(
                this.mockLogger.Object,
                this.mockTransactionRepository.Object);
        }

        [Fact]
        public void Create_ExpectedInsertModelToDatabase()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            Transactions model = new Transactions(); ;
            this.mockTransactionRepository.Setup(c => c.Save(It.IsAny<ActionModes>(), It.IsAny<Transactions>())).Returns(1);

            // Act
            transactionLogic.Create(
                model);

            // Assert
            this.mockTransactionRepository.Verify(c => c.Save(It.Is<ActionModes>(mode => mode == ActionModes.Create), It.IsAny<Transactions>()));
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Create_InsertToDatabaseSuccess_ExpectedReturnModel()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            Transactions model = new Transactions();
            this.mockTransactionRepository.Setup(c => c.Save(It.IsAny<ActionModes>(), It.IsAny<Transactions>())).Returns(1);

            // Act
            var result = transactionLogic.Create(
                model);

            // Assert
            result.Should().NotBeNull();
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Create_InsertToDatabaseFail_ExpectedReturnNull()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            Transactions model = new Transactions();
            this.mockTransactionRepository.Setup(c => c.Save(It.IsAny<ActionModes>(), It.IsAny<Transactions>())).Returns(0);

            // Act
            var result = transactionLogic.Create(
                model);

            // Assert
            result.Should().BeNull();
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Create_WhenInsertSuccess_ShouldSetCreateOnAndModifiedOn()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            Transactions model = new Transactions();
            var currentDateTime = DateTime.Now;
            Transactions modelToBeSaved = new Transactions();
            this.mockTransactionRepository.Setup(c => c.Save(It.IsAny<ActionModes>(), It.IsAny<Transactions>()))
                .Callback((ActionModes action, Transactions[] model) => modelToBeSaved = model[0])
                .Returns(1);
            // Act
            var result = transactionLogic.Create(
                model);

            // Assert
            modelToBeSaved.CreatedOn.Should().BeCloseTo(currentDateTime);
            modelToBeSaved.ModifiedOn.Should().BeCloseTo(currentDateTime);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Update_WhenExist_ShouldBeUpdateSuccess()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            Transactions model = new Transactions
            {
                Id = 474
            };
            Transactions existModel = new Transactions
            {
                Id = 474
            };
            List<Transactions> queryList = new List<Transactions>() { existModel };
            this.mockTransactionRepository.Setup(c => c.Get(It.IsAny<Expression<Func<Transactions, bool>>>())).Returns(queryList);
            this.mockTransactionRepository.Setup(c => c.Save(It.IsAny<ActionModes>(), It.IsAny<Transactions>())).Returns(1);

            // Act
            var result = transactionLogic.Update(model.Id,
                model);

            // Assert
            this.mockTransactionRepository.Verify(c => c.Save(It.Is<ActionModes>(mode => mode == ActionModes.Update), It.IsAny<Transactions>()));
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Update_WhenNotExist_ShouldBeNotUpdate()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            Transactions model = new Transactions
            {
                Id = 474
            };
            
            List<Transactions> queryList = new List<Transactions>() { };
            this.mockTransactionRepository.Setup(c => c.Get(It.IsAny<Expression<Func<Transactions, bool>>>())).Returns(queryList);

            // Act
            var result = transactionLogic.Update(model.Id,
                model);

            // Assert
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Update_WhenValidateSuccess_ShouldSaveToDatabase()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            Transactions model = new Transactions
            {
                Id = 474
            };
            this.mockTransactionRepository.Setup(c => c.Save(It.IsAny<ActionModes>(), It.IsAny<Transactions>())).Returns(1);

            Transactions existModel = new Transactions
            {
                Id = 474
            };
            List<Transactions> queryList = new List<Transactions>() { existModel };
            this.mockTransactionRepository.Setup(c => c.Get(It.IsAny<Expression<Func<Transactions, bool>>>())).Returns(queryList);

            // Act
            var result = transactionLogic.Update(model.Id,
                model);

            // Assert
            this.mockTransactionRepository.Verify(c => c.Save(It.Is<ActionModes>(mode => mode == ActionModes.Update), It.IsAny<Transactions>()));
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Update_WhenUpdateSuccess_ShouldSetModifiedOn()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            var currentDateTime = DateTime.Now;
            Transactions model = new Transactions
            {
                Id = 474
            };
            Transactions modelToBeSaved = new Transactions();
            this.mockTransactionRepository.Setup(c => c.Save(It.IsAny<ActionModes>(), It.IsAny<Transactions>()))
                .Callback((ActionModes action, Transactions[] model) => modelToBeSaved = model[0])
                .Returns(1);

            Transactions existModel = new Transactions
            {
                Id = 474
            };
            List<Transactions> queryList = new List<Transactions>() { existModel };
            this.mockTransactionRepository.Setup(c => c.Get(It.IsAny<Expression<Func<Transactions, bool>>>())).Returns(queryList);
            // Act


            var result = transactionLogic.Update(model.Id,
                model);

            // Assert
            modelToBeSaved.ModifiedOn.Should().BeCloseTo(currentDateTime);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Update_WhenUpdateSuccess_ShouldNotChangeCreateOn()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            var createdDateTime = DateTime.Now.AddDays(-2);
            Transactions model = new Transactions
            {
                Id = 474,
                CreatedOn = createdDateTime
            };
            Transactions modelToBeSaved = new Transactions();
            this.mockTransactionRepository.Setup(c => c.Save(It.IsAny<ActionModes>(), It.IsAny<Transactions>()))
                .Callback((ActionModes action, Transactions[] model) => modelToBeSaved = model[0])
                .Returns(1);

            Transactions existModel = new Transactions
            {
                Id = 474
            };
            List<Transactions> queryList = new List<Transactions>() { existModel };
            this.mockTransactionRepository.Setup(c => c.Get(It.IsAny<Expression<Func<Transactions, bool>>>())).Returns(queryList);

            // Act
            var result = transactionLogic.Update(model.Id,
                model);

            // Assert
            modelToBeSaved.CreatedOn.Should().BeCloseTo(createdDateTime);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Update_WhenUpdateSuccess_ExpectedReturnModel()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            Transactions model = new Transactions
            {
                Id = 474
            };
            this.mockTransactionRepository.Setup(c => c.Save(It.IsAny<ActionModes>(), It.IsAny<Transactions>())).Returns(1);

            Transactions existModel = new Transactions
            {
                Id = 474
            };
            List<Transactions> queryList = new List<Transactions>() { existModel };
            this.mockTransactionRepository.Setup(c => c.Get(It.IsAny<Expression<Func<Transactions, bool>>>())).Returns(queryList);

            // Act
            var result = transactionLogic.Update(model.Id,
                model);

            // Assert
            result.Should().NotBeNull();
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Update_WhenUpdateFail_ExpectedReturnNull()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            Transactions model = new Transactions
            {
                Id = 474
            };
            this.mockTransactionRepository.Setup(c => c.Save(It.IsAny<ActionModes>(), It.IsAny<Transactions>())).Returns(0);

            Transactions existModel = new Transactions
            {
                Id = 474
            };
            List<Transactions> queryList = new List<Transactions>() { existModel };
            this.mockTransactionRepository.Setup(c => c.Get(It.IsAny<Expression<Func<Transactions, bool>>>())).Returns(queryList);

            // Act
            var result = transactionLogic.Update(model.Id,
                model);

            // Assert
            result.Should().BeNull();
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Delete_WhenExist_ShouldBeDeleteSuccess()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            Transactions existModel = new Transactions
            {
                Id = 474
            };
            List<Transactions> queryList = new List<Transactions>() { existModel };
            this.mockTransactionRepository.Setup(c => c.Get(It.IsAny<Expression<Func<Transactions, bool>>>())).Returns(queryList);
            Transactions modelToBeSaved = new Transactions();
            this.mockTransactionRepository.Setup(c => c.Save(It.IsAny<ActionModes>(), It.IsAny<Transactions>()))
                .Callback((ActionModes action, Transactions[] model) => modelToBeSaved = model[0])
                .Returns(1);

            // Act
            var result = transactionLogic.Remove(474);

            // Assert
            modelToBeSaved.Should().NotBeNull();
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void GET_WhenExist_ShouldBeReturnResult()
        {
            // Arrange
            var transactionLogic = this.CreateTransactionLogic();
            Transactions existModel = new Transactions
            {
                Id = 474
            };
            List<Transactions> queryList = new List<Transactions>() { existModel };
            this.mockTransactionRepository.Setup(c => c.Get(It.IsAny<Expression<Func<Transactions, bool>>>(), It.IsAny<Expression<Func<Transactions, object>>>())).Returns(queryList);

            // Act
            var result = transactionLogic.FindBy();

            // Assert
            result.Should().NotBeNull();
            this.mockRepository.VerifyAll();
        }



    }
}
