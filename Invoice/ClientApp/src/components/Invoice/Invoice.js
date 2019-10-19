import React, { Component } from "react";
import LineItems from "./LineItems";

import uuidv4 from "uuid/v4";

class Invoice extends Component {
	locale = "en-US";
	currency = "USD";

	state = {
		taxRate: 0.0,
		lineItems: [
			{
				id: "initial",
				quantity: 0,
				name: "",
				description: "",
				price: 0.0
			}
		]
	};

	//When there is a change in value it takes the old value and
	//replaces it with the new value
	//This will later get added into LineItems
	handleInvoicechange = event =>
		this.setState({ [event.target.name]: event.target.value });

	//Detects for a change in the lineitem
	//This will later get added into LineItems
	handleLineItemChange = elementIndex => event => {
		let lineItems = this.state.lineItems.map((item, i) => {
			if (elementIndex !== i) return item;
			return { ...item, [event.target.name]: event.target.value };
		});
		this.setState({ lineItems });
	};

	//Allows us to add a line to the list of items
	handleAddLineItem = event => {
		this.setState({
			lineItems: this.state.lineItems.concat([
				{ id: uuidv4(), quantity: 0, name: "", description: "", price: 0.0 }
			])
		});
	};

	//Deletes a row from the lis tof items
	handleRemoveLineItem = elementIndex => event => {
		this.setState({
			lineItems: this.state.lineItems.filter((item, i) => {
				return elementIndex !== i;
			})
		});
	};

	//Reorders the lis of items
	handleReorderLineItems = newLineItems => {
		this.setState({
			lineItems: newLineItems
		});
	};

	//Focuses on a item
	handleFocusSelect = event => {
		event.target.select();
	};

	//The pay button
	handlePayButtonClick = () => {
		alert("Paid");
	};

	//Formats the amount given to a currency
	//This will late rbe added to LineItems
	formatCurrency = amount => {
		return new Intl.NumberFormat(this.locale, {
			style: "currency",
			currency: this.currency,
			minimumFractionDigits: 2,
			maximumFractionDigits: 2
		}).format(amount);
	};

	//Given the tax amount we calculate the tax given a amound
	calculateTaxAmount = c => {
		return c * (this.state.taxRate / 100);
	};

	//Will calculate the total for all the line items
	calculateLineItemsTotal = () => {
		return this.state.lineItems.reduce(
			(prev, curr) => prev + curr.quantity * curr.price,
			0
		);
	};

	//This will calculate the total with tax
	calculateTaxTotal = () => {
		return this.calculateLineItemsTotal() + this.taxRate / 100;
	};

	//This will add the Total and the total with tax
	calculateGrandTotal = () => {
		return this.calculateLineItemsTotal() + this.calculateTaxTotal();
	};

	render = () => {
		return (
			<div>
				<h1>This is the Invoice</h1>
			</div>
		);
	};
}

export default Invoice;
