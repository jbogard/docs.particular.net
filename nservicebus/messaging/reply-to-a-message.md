---
title: Replying to a Message
summary: Answer a message using the Reply method on IMessageHandlerContext/IBus.
component: Core
reviewed: 2018-10-11
redirects:
- nservicebus/how-do-i-reply-to-a-message
---

The simplest way to reply to a message is using the `Reply` method:

snippet: ReplyingMessageHandler

Only use a reply when implementing the Request-Response pattern (also called the Full Duplex pattern). In this pattern the originator of the message should expect a response message and have a handler for it. For examples and more information see the [Full Duplex Sample](/samples/fullduplex/) and the article [Callbacks](/nservicebus/messaging/callbacks.md).

When using the Publish-Subscribe pattern, an endpoint handling an event shouldn't use `Reply`. This is because the publisher might not expect a reply and has no message handler for the replied message.

The reply address is controlled by the sender of the message replying to. See [how to influence the reply behavior when sending messages](send-a-message.md#influencing-the-reply-behavior).

partial: influence
