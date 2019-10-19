import React, { Component } from "react";
import { Route } from "react-router";
import { Layout } from "./components/Layout";
import { Home } from "./components/Home";
import { FetchData } from "./components/FetchData";
import { Counter } from "./components/Counter";
import Invoice from "./components/Invoice/Invoice";
import Customer from "./components/Customers/Customer";
import Company from "./components/Company";

export default class App extends Component {
	displayName = App.name;

	render() {
		return (
			<Layout>
				<Route exact path="/" component={Home} />
				<Route path="/customer" component={Customer} />
				<Route path="/company" component={Company} />
				<Route path="/invoice" component={Invoice} />
				<Route path="/counter" component={Counter} />
				<Route path="/fetchdata" component={FetchData} />
			</Layout>
		);
	}
}
