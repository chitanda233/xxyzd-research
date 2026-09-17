package com.onevcat.uniwebview;

import android.app.Activity;
import android.content.Intent;
import java.util.UUID;
import kotlin.Unit;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.i0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0646i0 extends Lambda implements Function0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ String f2901a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0646i0(String str) {
        super(0);
        this.f2901a = str;
    }

    @Override // kotlin.jvm.functions.Function0
    public final Object invoke() {
        C0630d c0630d = C0630d.b;
        String name = this.f2901a;
        c0630d.getClass();
        Intrinsics.checkNotNullParameter(name, "name");
        A handler = (A) c0630d.f2885a.get(name);
        if (handler != null) {
            InterfaceC0695y.f2943a.getClass();
            Intrinsics.checkNotNullParameter(handler, "handler");
            String handlerId = UUID.randomUUID().toString();
            Intrinsics.checkNotNullExpressionValue(handlerId, "randomUUID().toString()");
            C0692x.b.put(handlerId, handler);
            handler.g = handlerId;
            C0698z c0698z = UniWebViewAuthenticationActivity.Companion;
            Activity context = handler.b;
            if (handlerId == null) {
                Intrinsics.throwUninitializedPropertyAccessException("handlerId");
                handlerId = null;
            }
            c0698z.getClass();
            Intrinsics.checkNotNullParameter(context, "context");
            Intrinsics.checkNotNullParameter(handlerId, "handlerId");
            Intent intent = new Intent(context, (Class<?>) UniWebViewAuthenticationActivity.class);
            intent.putExtra(UniWebViewProxyActivity.HANDLER_ID, handlerId);
            context.startActivity(intent);
        }
        return Unit.INSTANCE;
    }
}
