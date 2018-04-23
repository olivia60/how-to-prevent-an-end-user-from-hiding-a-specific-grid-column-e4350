# How to prevent an end-user from hiding a specific grid column


<p>This example demonstrates how to prevent an end-user from hiding a specific grid column. For this, you first need to create a <strong>RemoveColumnDropTarget</strong> class descendant and override the <strong>Drop</strong> method. Then, create a <strong>TableView</strong> class descendant and override the <strong>CreateEmptyDropTarget</strong> method, which should return an instance of the <strong>RemoveColumnDropTarget</strong> descendant. And finally, create an attached property for the AbsoluteVisible.<strong>IsEnable</strong> columns.<br><br></p>
<p>To prevent all columns from being hidden, use the built-in <a href="https://documentation.devexpress.com/WPF/DevExpressXpfGridDataViewBase_AllowMoveColumnToDropAreatopic.aspx">AllowMoveColumnToDropArea</a> property.</p>

<br/>


