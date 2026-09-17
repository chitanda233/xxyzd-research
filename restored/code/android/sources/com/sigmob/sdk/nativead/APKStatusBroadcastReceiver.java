package com.sigmob.sdk.nativead;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import com.czhj.sdk.common.utils.Preconditions;
import com.sigmob.sdk.base.common.BaseBroadcastReceiver;
import com.sigmob.sdk.base.models.IntentActions;

/* JADX INFO: loaded from: classes4.dex */
public class APKStatusBroadcastReceiver extends BaseBroadcastReceiver {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    com.sigmob.sdk.base.common.b f3559a;
    IntentFilter b;

    public APKStatusBroadcastReceiver(com.sigmob.sdk.base.common.b listener, String broadcastIdentifier) {
        super(broadcastIdentifier);
        this.f3559a = listener;
    }

    @Override // com.sigmob.sdk.base.common.BaseBroadcastReceiver
    public IntentFilter a() {
        if (this.b == null) {
            IntentFilter intentFilter = new IntentFilter();
            this.b = intentFilter;
            intentFilter.addAction(IntentActions.ACTION_INTERSTITIAL_DOWNLOAD_START);
            this.b.addAction(IntentActions.ACTION_INTERSTITIAL_DOWNLOAD_PAUSE);
            this.b.addAction(IntentActions.ACTION_INTERSTITIAL_DOWNLOAD_END);
            this.b.addAction(IntentActions.ACTION_INTERSTITIAL_INSTALL_START);
            this.b.addAction(IntentActions.ACTION_INTERSTITIAL_INSTALL_END);
        }
        return this.b;
    }

    @Override // com.sigmob.sdk.base.common.BaseBroadcastReceiver
    public void b(BroadcastReceiver broadcastReceiver) {
        super.b(broadcastReceiver);
        this.f3559a = null;
    }

    @Override // android.content.BroadcastReceiver
    public void onReceive(Context context, Intent intent) {
        String action;
        Preconditions.NoThrow.checkNotNull(context);
        Preconditions.NoThrow.checkNotNull(intent);
        if (this.f3559a == null || !a(intent) || (action = intent.getAction()) == null) {
            return;
        }
        boolean zEqualsIgnoreCase = "1".equalsIgnoreCase(intent.getStringExtra(com.alipay.sdk.m.y.o.c));
        long longExtra = intent.getLongExtra("downloadId", -1L);
        action.hashCode();
        switch (action) {
            case "action.interstitial.download.end":
                this.f3559a.b(zEqualsIgnoreCase, longExtra);
                break;
            case "action.interstitial.download.pause":
                this.f3559a.c(zEqualsIgnoreCase, longExtra);
                break;
            case "action.interstitial.download.start":
                this.f3559a.a(zEqualsIgnoreCase, longExtra);
                break;
            case "action.interstitial.install.end":
                this.f3559a.b(zEqualsIgnoreCase);
                break;
            case "action.interstitial.install.start":
                this.f3559a.a(zEqualsIgnoreCase);
                break;
        }
    }
}
