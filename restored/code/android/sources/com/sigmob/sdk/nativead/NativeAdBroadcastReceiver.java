package com.sigmob.sdk.nativead;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.text.TextUtils;
import com.czhj.sdk.common.utils.Preconditions;
import com.sigmob.sdk.base.common.BaseBroadcastReceiver;
import com.sigmob.sdk.base.models.IntentActions;

/* JADX INFO: loaded from: classes4.dex */
public class NativeAdBroadcastReceiver extends BaseBroadcastReceiver {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static IntentFilter f3561a;
    private g b;

    public NativeAdBroadcastReceiver(g listener, String broadcastIdentifier) {
        super(broadcastIdentifier);
        this.b = listener;
        a();
    }

    @Override // com.sigmob.sdk.base.common.BaseBroadcastReceiver
    public IntentFilter a() {
        if (f3561a == null) {
            IntentFilter intentFilter = new IntentFilter();
            f3561a = intentFilter;
            intentFilter.addAction(IntentActions.ACTION_NATIVE_TEMPLIE_SHOW);
            f3561a.addAction(IntentActions.ACTION_NATIVE_TEMPLE_CLICK);
            f3561a.addAction(IntentActions.ACTION_NATIVE_TEMPLE_DISMISS);
            f3561a.addAction(IntentActions.ACTION_LANDPAGE_SHOW);
            f3561a.addAction(IntentActions.ACTION_LANDPAGE_DISMISS);
        }
        return f3561a;
    }

    @Override // com.sigmob.sdk.base.common.BaseBroadcastReceiver
    public void b(BroadcastReceiver broadcastReceiver) {
        super.b(broadcastReceiver);
        this.b = null;
    }

    @Override // android.content.BroadcastReceiver
    public void onReceive(Context context, Intent intent) {
        Preconditions.NoThrow.checkNotNull(context);
        Preconditions.NoThrow.checkNotNull(intent);
        if (this.b != null && a(intent)) {
            String action = intent.getAction();
            if (TextUtils.isEmpty(action)) {
                return;
            }
            action.hashCode();
            switch (action) {
                case "action.native.temple.dismiss":
                    this.b.i();
                    break;
                case "action.native.temple.click":
                    this.b.h();
                    break;
                case "action.native.temple.show":
                    this.b.g();
                    break;
                case "action.loadpage.show":
                    this.b.a();
                    break;
                case "action.loadpage.dismiss":
                    this.b.b();
                    break;
            }
        }
    }
}
