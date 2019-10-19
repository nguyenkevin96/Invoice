import React, { Component } from "react";
import PropTypes from "prop-types";

class LineItems extends Component {
	render = () => {
		const { index, quantity, name, description, price } = this.props;

		return (
			<div>
				<div>{index + 1}</div>
				<div>
					<input
						name="quantity"
						type="number"
						value={quantity}
						onChange={this.props.changeHandler(index)}
					/>
				</div>
				<div>
					<input
						name="name"
						type="text"
						value={name}
						onChange={this.props.changeHandler(index)}
					/>
				</div>
				<div>
					<input
						name="description"
						type="text"
						value={description}
						onChange={this.props.changeHandler(index)}
					/>
				</div>
				<div>
					<input
						name="price"
						type="number"
						value={price}
						step="0.01"
						min="0.00"
						max="9999999.99"
						onChange={this.props.changeHandler(index)}
						onFocus={this.props.focusHandler}
					/>
				</div>
				<div>{this.props.currencyFormatter(quantity * price)}</div>
			</div>
		);
	};
}

export default LineItems;

LineItems.propTypes = {
	index: PropTypes.number.isRequired,
	name: PropTypes.string,
	description: PropTypes.string,
	quantity: PropTypes.number,
	price: PropTypes.number
};
