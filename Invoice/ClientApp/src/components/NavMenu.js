﻿import React, { Component } from "react";
import { Link } from "react-router-dom";
import { Glyphicon, Nav, Navbar, NavItem } from "react-bootstrap";
import { LinkContainer } from "react-router-bootstrap";
import "./NavMenu.css";
import logo from "./Logo.PNG";

export class NavMenu extends Component {
	displayName = NavMenu.name;

	render() {
		return (
			<Navbar inverse fixedTop fluid collapseOnSelect>
				<Navbar.Header>
					<Navbar.Brand>
						<Link to={"/"}>
							<div class="logo">
								<img src={logo} class="logo" alt="Logo" />
							</div>
						</Link>
					</Navbar.Brand>
					<Navbar.Toggle />
				</Navbar.Header>
				<Navbar.Collapse>
					<Nav>
						<LinkContainer to={"/"} exact>
							<NavItem>
								<Glyphicon glyph="th" /> Home
							</NavItem>
						</LinkContainer>
						<LinkContainer to={"/customer"}>
							<NavItem>
								<Glyphicon glyph="user" /> Customers
							</NavItem>
						</LinkContainer>
						<LinkContainer to={"/company"}>
							<NavItem>
								<Glyphicon glyph="home" /> Companies
							</NavItem>
						</LinkContainer>
						<LinkContainer to={"/invoice"}>
							<NavItem>
								<Glyphicon glyph="list-alt" /> Invoice
							</NavItem>
						</LinkContainer>
						<LinkContainer to={"/counter"}>
							<NavItem>
								<Glyphicon glyph="education" /> Counter
							</NavItem>
						</LinkContainer>
						<LinkContainer to={"/fetchdata"}>
							<NavItem>
								<Glyphicon glyph="th-list" /> Fetch data
							</NavItem>
						</LinkContainer>
					</Nav>
				</Navbar.Collapse>
			</Navbar>
		);
	}
}
