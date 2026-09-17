package com.sigmob.sdk.base.common;

import android.app.Activity;
import android.content.Intent;
import android.content.res.Configuration;
import android.os.Build;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.Constants;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.sdk.logger.SigmobLogger;
import com.sigmob.sdk.base.BaseAdActivity;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.IntentActions;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import java.util.HashMap;

/* JADX INFO: loaded from: classes3.dex */
public class AdActivity extends BaseAdActivity implements k {
    private static final String k = "AdActivity";
    private j l;
    private String m;
    private BaseAdUnit n;
    private boolean o;
    private boolean p;

    private j a(BaseAdUnit baseAdUnit, Bundle savedInstanceState) throws IllegalStateException {
        Intent intent = getIntent();
        String stringExtra = intent.getStringExtra("ad_view_class_name");
        Bundle extras = intent.getExtras();
        if (stringExtra == null) {
            return null;
        }
        this.n = baseAdUnit;
        stringExtra.hashCode();
        switch (stringExtra) {
            case "LandNative":
                if (extras == null) {
                    return null;
                }
                return new com.sigmob.sdk.nativead.z(this, baseAdUnit, extras, savedInstanceState, this.m, this);
            case "LandPage":
                return new w(this, baseAdUnit, extras, savedInstanceState, this.m, this);
            case "DisLike":
                return new com.sigmob.sdk.nativead.w(this, baseAdUnit, extras, savedInstanceState, this.m, this);
            case "reward":
                return new com.sigmob.sdk.videoAd.j(this, baseAdUnit, extras, savedInstanceState, this.m, this);
            case "new_interstitial":
                return new com.sigmob.sdk.newInterstitial.i(this, baseAdUnit, extras, savedInstanceState, this.m, this);
            case "mraid":
                return new com.sigmob.sdk.mraid.s(this, baseAdUnit, extras, savedInstanceState, this.m, this);
            case "mraid_two":
                return new com.sigmob.sdk.mraid2.s(this, baseAdUnit, extras, savedInstanceState, this.m, this);
            default:
                return null;
        }
    }

    private static String a(Intent intent) {
        return intent.getStringExtra(Constants.BROADCAST_IDENTIFIER_KEY);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(Object obj) {
        if (obj instanceof PointEntitySigmob) {
        }
    }

    private void a(HashMap<String, Object> map) {
        BaseBroadcastReceiver.a(this, this.m, map, IntentActions.ACTION_REWARDED_VIDEO_PLAYFAIL);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b() {
        BaseAdUnit baseAdUnit;
        if (isFinishing() || isDestroyed() || (baseAdUnit = this.n) == null || this.l == null || baseAdUnit.getAd_type() != 6) {
            return;
        }
        if (this.o || this.p) {
            if (com.sigmob.sdk.base.utils.v.b(Boolean.valueOf(this.l instanceof com.sigmob.sdk.newInterstitial.i))) {
                com.sigmob.sdk.base.network.h.a(this.n, a.u);
                ad.a(a.u, (String) null, this.n, new ad.a() { // from class: com.sigmob.sdk.base.common.AdActivity$$ExternalSyntheticLambda1
                    @Override // com.sigmob.sdk.base.common.ad.a
                    public final void onAddExtra(Object obj) {
                        AdActivity.a(obj);
                    }
                });
                this.n.setSessionManager(null);
            }
            finish();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void c() {
        SigmobLogger.d(k, "onCreate#onTimerFinished", new Object[0]);
        this.p = true;
        runOnUiThread(new Runnable() { // from class: com.sigmob.sdk.base.common.AdActivity$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.b();
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void d() {
        this.o = true;
        BaseAdUnit baseAdUnit = this.n;
        if (baseAdUnit == null) {
            return;
        }
        int interactionType = baseAdUnit.getInteractionType();
        boolean zEnableSmallWindow = this.n.enableSmallWindow(Integer.valueOf(interactionType));
        if (interactionType == 2 || zEnableSmallWindow) {
            b();
        }
    }

    @Override // com.sigmob.sdk.base.common.k
    public void a() {
        finish();
        overridePendingTransition(0, 0);
    }

    @Override // com.sigmob.sdk.base.common.k
    public void a(final int requestedOrientation) {
        setRequestedOrientation(requestedOrientation);
    }

    @Override // com.sigmob.sdk.base.common.k
    public void a(Class<? extends Activity> clazz, int requestCode, Bundle extras) {
        if (clazz == null) {
            return;
        }
        try {
            startActivityForResult(com.sigmob.sdk.base.utils.h.a(this, clazz, extras), requestCode);
        } catch (Throwable unused) {
            SigmobLog.d("Activity " + clazz.getName() + " not found. Did you declare it in your AndroidManifest.xml?");
        }
    }

    @Override // android.app.Activity
    public void finish() {
        super.finish();
    }

    @Override // android.app.Activity
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        j jVar = this.l;
        if (jVar == null) {
            return;
        }
        jVar.a(requestCode, resultCode, data);
    }

    @Override // android.app.Activity, com.sigmob.sdk.base.common.k
    public void onBackPressed() {
        j jVar = this.l;
        if (jVar == null || !jVar.j()) {
            return;
        }
        super.onBackPressed();
        this.l.i();
    }

    @Override // android.app.Activity, android.content.ComponentCallbacks
    public void onConfigurationChanged(final Configuration newConfig) {
        super.onConfigurationChanged(newConfig);
        j jVar = this.l;
        if (jVar == null) {
            return;
        }
        jVar.a(newConfig);
    }

    @Override // android.app.Activity
    protected void onCreate(Bundle savedInstanceState) {
        com.sigmob.sdk.videoplayer.c.e((Activity) this);
        super.onCreate(savedInstanceState);
        this.m = a(getIntent());
        String stringExtra = getIntent().getStringExtra("adUnit_requestId_key");
        try {
            if (ClientMetadata.getInstance() != null && !TextUtils.isEmpty(stringExtra)) {
                BaseAdUnit baseAdUnitC = h.c(stringExtra);
                if (!this.m.equals("dislike_broadcastIdentifier") && baseAdUnitC == null) {
                    HashMap<String, Object> map = new HashMap<>();
                    map.put("error", "playAdUnit is null");
                    a(map);
                    finish();
                    return;
                }
                j jVarA = a(baseAdUnitC, savedInstanceState);
                this.l = jVarA;
                if (jVarA == null) {
                    return;
                }
                jVarA.e();
                if (com.sigmob.sdk.base.utils.v.a(baseAdUnitC.allowClickToAutoClose())) {
                    this.l.a(new j.a() { // from class: com.sigmob.sdk.base.common.AdActivity$$ExternalSyntheticLambda2
                        @Override // com.sigmob.sdk.base.common.j.a
                        public final void onAdClicked() {
                            this.f$0.d();
                        }
                    });
                }
                Integer numAllowCountdownEndsClose = baseAdUnitC.allowCountdownEndsClose();
                if (com.sigmob.sdk.base.utils.v.a((Number) numAllowCountdownEndsClose)) {
                    j jVar = this.l;
                    if (jVar instanceof com.sigmob.sdk.newInterstitial.i) {
                        ((com.sigmob.sdk.newInterstitial.i) jVar).a(numAllowCountdownEndsClose.intValue(), new com.sigmob.sdk.base.utils.o.a() { // from class: com.sigmob.sdk.base.common.AdActivity$$ExternalSyntheticLambda3
                            @Override // com.sigmob.sdk.base.utils.o.a
                            public final void onTimerFinished() {
                                this.f$0.c();
                            }
                        });
                        return;
                    }
                    return;
                }
                return;
            }
            SigmobLog.e("uuid is empty");
            HashMap<String, Object> map2 = new HashMap<>();
            map2.put("error", "uuid is empty");
            a(map2);
            finish();
        } catch (Throwable th) {
            SigmobLog.e("AdActivity onCreate Throwable: " + th.getMessage(), th);
            HashMap<String, Object> map3 = new HashMap<>();
            map3.put("error", th.getMessage());
            a(map3);
            finish();
        }
    }

    @Override // android.app.Activity
    protected void onDestroy() {
        SigmobLog.d("RewardVideoAdPlayerActivity onDestroy() called");
        if (com.sigmob.sdk.base.utils.v.b(this.l)) {
            this.l.h();
        }
        this.l = null;
        super.onDestroy();
    }

    @Override // android.app.Activity
    protected void onPause() {
        super.onPause();
        j jVar = this.l;
        if (jVar == null) {
            return;
        }
        try {
            jVar.f();
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
            HashMap<String, Object> map = new HashMap<>();
            map.put("error", th.getMessage());
            a(map);
            finish();
        }
    }

    @Override // android.app.Activity
    protected void onRestart() {
        super.onRestart();
        b();
    }

    @Override // android.app.Activity
    protected void onResume() {
        super.onResume();
        j jVar = this.l;
        if (jVar == null) {
            return;
        }
        try {
            jVar.g();
        } catch (Throwable th) {
            HashMap<String, Object> map = new HashMap<>();
            map.put("error", th.getMessage());
            a(map);
            finish();
        }
    }

    @Override // android.app.Activity
    protected void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
        j jVar = this.l;
        if (jVar == null) {
            return;
        }
        jVar.a(outState);
    }

    @Override // com.sigmob.sdk.base.common.k
    public void onSetContentView(final View view) {
        setContentView(view);
    }

    @Override // android.app.Activity
    protected void onStart() {
        super.onStart();
        j jVar = this.l;
        if (jVar == null) {
            return;
        }
        try {
            jVar.o();
        } catch (Throwable unused) {
        }
    }

    @Override // android.app.Activity
    protected void onStop() {
        super.onStop();
    }

    @Override // android.app.Activity
    public void setRequestedOrientation(int requestedOrientation) {
        try {
            if (Build.VERSION.SDK_INT == 26 && com.sigmob.sdk.videoplayer.c.g((Activity) this)) {
                return;
            }
            super.setRequestedOrientation(requestedOrientation);
        } catch (Exception e) {
            SigmobLog.e("setRequestedOrientation: " + e.getMessage());
        }
    }
}
