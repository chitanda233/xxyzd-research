package com.sigmob.sdk.base.common;

import android.os.Bundle;
import com.sigmob.sdk.base.models.BaseAdUnit;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public abstract class y {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected p f3205a;
    protected BaseAdUnit b;
    private EventForwardingBroadcastReceiver c;

    protected y(p customEventInterstitialListener) {
        this.f3205a = customEventInterstitialListener;
    }

    protected abstract void a(p customEventInterstitialListener);

    public void a(BaseAdUnit baseAdUnit, Bundle option) {
        if (baseAdUnit == null) {
            if (com.sigmob.sdk.base.utils.v.b(this.f3205a)) {
                this.f3205a.b(null, "ad unit is unavailable.");
            }
        } else {
            EventForwardingBroadcastReceiver eventForwardingBroadcastReceiver = new EventForwardingBroadcastReceiver(baseAdUnit, this.f3205a, baseAdUnit.getUuid());
            this.c = eventForwardingBroadcastReceiver;
            eventForwardingBroadcastReceiver.a(eventForwardingBroadcastReceiver);
        }
    }

    public void a(Map<String, Object> localExtras, BaseAdUnit adUnit) {
        this.b = adUnit;
        a(this.f3205a);
    }

    protected abstract boolean a(BaseAdUnit adUnit);

    /* JADX WARN: Type inference fix 'apply assigned field type' failed
    java.lang.UnsupportedOperationException: ArgType.getObject(), call class: class jadx.core.dex.instructions.args.ArgType$UnknownArg
    	at jadx.core.dex.instructions.args.ArgType.getObject(ArgType.java:596)
    	at jadx.core.dex.attributes.nodes.ClassTypeVarsAttr.getTypeVarsMapFor(ClassTypeVarsAttr.java:35)
    	at jadx.core.dex.nodes.utils.TypeUtils.replaceClassGenerics(TypeUtils.java:177)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.insertExplicitUseCast(FixTypesVisitor.java:397)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.tryFieldTypeWithNewCasts(FixTypesVisitor.java:359)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.applyFieldType(FixTypesVisitor.java:309)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:94)
     */
    public void b(BaseAdUnit baseAdUnit) {
        if (com.sigmob.sdk.base.utils.v.b(baseAdUnit)) {
            h.b(baseAdUnit);
            baseAdUnit.destroy();
        }
        this.b = null;
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            EventForwardingBroadcastReceiver eventForwardingBroadcastReceiver = this.c;
            eventForwardingBroadcastReceiver.b(eventForwardingBroadcastReceiver);
        }
    }
}
