package com.sigmob.sdk.splash;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import com.czhj.sdk.common.utils.Preconditions;
import com.sigmob.sdk.base.common.BaseBroadcastReceiver;
import com.sigmob.sdk.base.models.IntentActions;
import com.sigmob.sdk.base.utils.s;

/* JADX INFO: loaded from: classes4.dex */
public class SplashAdBroadcastReceiver extends BaseBroadcastReceiver {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static IntentFilter f3615a;
    private e b;

    public SplashAdBroadcastReceiver(e adInteractionListener, String uuid) {
        super(uuid);
        this.b = adInteractionListener;
        a();
    }

    @Override // com.sigmob.sdk.base.common.BaseBroadcastReceiver
    public IntentFilter a() {
        if (f3615a == null) {
            IntentFilter intentFilter = new IntentFilter();
            f3615a = intentFilter;
            intentFilter.addAction(IntentActions.ACTION_SPLAH_STOP_TIME);
            f3615a.addAction(IntentActions.ACTION_SPLAH_PLAYFAIL);
            f3615a.addAction(IntentActions.ACTION_SPLAH_SKIP);
            f3615a.addAction(IntentActions.ACTION_LANDPAGE_SHOW);
            f3615a.addAction(IntentActions.ACTION_LANDPAGE_DISMISS);
        }
        return f3615a;
    }

    @Override // com.sigmob.sdk.base.common.BaseBroadcastReceiver
    public void b(BroadcastReceiver broadcastReceiver) {
        super.b(broadcastReceiver);
        this.b = null;
    }

    @Override // android.content.BroadcastReceiver
    public void onReceive(final Context context, final Intent intent) {
        Preconditions.NoThrow.checkNotNull(context);
        Preconditions.NoThrow.checkNotNull(intent);
        if (this.b != null && a(intent)) {
            String action = intent.getAction();
            if (s.a((CharSequence) action)) {
                return;
            }
            action.hashCode();
            switch (action) {
                case "action.splash.playFail":
                    this.b.b_();
                    break;
                case "action.splash.play":
                    this.b.d_();
                    break;
                case "action.splash.skip":
                    this.b.c_();
                    break;
                case "action.loadpage.show":
                    this.b.a();
                    break;
                case "action.splash.stoptime":
                    this.b.a_();
                    break;
                case "action.loadpage.dismiss":
                    this.b.b();
                    break;
            }
        }
    }
}
