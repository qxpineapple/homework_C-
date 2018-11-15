<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>
    <xsl:template match='/'>
      <html>
        <body>
          <h2>Order List</h2>
          <table border='1'>
            <tr bgcolor='#9acd32'>
              <th align="left">Id</th>
              <th align="left">Customer</th>
              <th align="left">Phone</th>
              <th align="left">Item</th>
              <th align="left">Count</th>
            </tr>
            <xsl:for-each select="ArrayOfOrder/Order">
              <tr>
                <td>
                  <xsl:value-of select="Time"/>
                </td>
                <td>
                  <xsl:value-of select="CustomerName"/>
                </td>
                <td>
                  <xsl:value-of select="Phone"/>
                </td>
                <td>
                  <xsl:value-of select="ItemName"/>
                </td>
                <td>
                  <xsl:value-of select="Count"/>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
 </xsl:stylesheet>


