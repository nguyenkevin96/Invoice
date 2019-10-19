import React, { Component } from "react";
import "./customerstyle.css";

class Customer extends Component {
	constructor(props) {
		super(props);
		this.state = {
			customers: [],
			loading: false
		};
	}

	componentDidMount() {
		fetch("/api/Customers")
			.then(res => res.json())
			.then(json => {
				this.setState({
					loading: true,
					customers: json
				});
			});
	}

	renderTableData() {
		return this.state.customers.map(customer => {
			return (
				<tr key={customer.custId}>
					<td>{customer.custName}</td>
					<td>{customer.custPhone}</td>
					<td>{customer.custAddress}</td>
					<td>{customer.custAddiAddr}</td>
					<td>{customer.custEmail}</td>
				</tr>
			);
		});
	}

	render() {
		var { loading, customers } = this.state;

		if (!loading) {
			return <div>Loading...</div>;
		} else {
			return (
				<div>
					<h1 class="title">Customer Table</h1>
					<table class="customers">
						<thead>
							<tr>
								<td rowSpan="2">Name</td>
								<td rowSpan="2">Phone</td>
								<td colSpan="2">Address</td>
								<td rowSpan="2">Email</td>
							</tr>
							<tr>
								<td>Address</td>
								<td>City, State, Zipcode</td>
							</tr>
							<tr></tr>
						</thead>
						<tbody>{this.renderTableData()}</tbody>
					</table>
				</div>
			);
		}
	}
}

export default Customer;
