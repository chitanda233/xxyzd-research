package com.sigmob.sdk.videoAd;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.text.TextUtils;
import com.czhj.sdk.common.utils.Preconditions;
import com.sigmob.sdk.base.common.BaseBroadcastReceiver;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.IntentActions;

/* JADX INFO: loaded from: classes4.dex */
public class RewardVideoAdBroadcastReceiver extends BaseBroadcastReceiver {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static IntentFilter f3632a;
    private h b;
    private BaseAdUnit c;

    public RewardVideoAdBroadcastReceiver(BaseAdUnit adUnit, h rewardVideoListener, String broadcastIdentifier) {
        super(broadcastIdentifier);
        this.c = adUnit;
        this.b = rewardVideoListener;
        a();
    }

    @Override // com.sigmob.sdk.base.common.BaseBroadcastReceiver
    public IntentFilter a() {
        if (f3632a == null) {
            IntentFilter intentFilter = new IntentFilter();
            f3632a = intentFilter;
            intentFilter.addAction(IntentActions.ACTION_REWARDED_VIDEO_PLAY);
            f3632a.addAction(IntentActions.ACTION_REWARDED_VIDEO_SKIP);
            f3632a.addAction(IntentActions.ACTION_REWARDED_VIDEO_PLAYFAIL);
            f3632a.addAction(IntentActions.ACTION_REWARDED_VIDEO_COMPLETE);
            f3632a.addAction(IntentActions.ACTION_REWARDED_VIDEO_CLOSE);
        }
        return f3632a;
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
        if (this.b == null || this.c == null || !a(intent)) {
            return;
        }
        String action = intent.getAction();
        if (TextUtils.isEmpty(action)) {
            return;
        }
        action.hashCode();
        switch (action) {
            case "action.rewardedvideo.playFail":
                this.b.c(this.c, intent.getStringExtra("error"));
                break;
            case "action.rewardedvideo.play":
                this.b.q(this.c);
                return;
            case "action.rewardedvideo.skip":
                this.b.r(this.c);
                return;
            case "action.rewardedvideo.complete":
                this.b.p(this.c);
                return;
            case "action.rewardedvideo.Close":
                this.b.s(this.c);
                break;
            default:
                return;
        }
        b(this);
        this.c = null;
    }
}
