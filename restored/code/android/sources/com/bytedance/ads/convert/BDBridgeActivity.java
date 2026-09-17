package com.bytedance.ads.convert;

import android.app.Activity;
import android.content.ActivityNotFoundException;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.text.TextUtils;
import android.util.Log;
import android.view.View;
import com.byazt.tk.AdBaseConstants;
import com.bykv.vk.component.ttvideo.player.C;
import com.bytedance.ads.convert.flat.i.c;
import com.bytedance.ads.convert.flat.i.d;
import com.bytedance.ads.convert.flat.i.f;
import java.util.HashMap;
import kotlin.Metadata;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: loaded from: classes2.dex */
@Metadata(bv = {1, 0, 3}, d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0007\u0018\u0000 \u000f2\u00020\u0001:\u0001\u0010B\u0007¢\u0006\u0004\b\u000e\u0010\u0004J\u000f\u0010\u0003\u001a\u00020\u0002H\u0002¢\u0006\u0004\b\u0003\u0010\u0004J\u000f\u0010\u0006\u001a\u00020\u0005H\u0002¢\u0006\u0004\b\u0006\u0010\u0007J\u000f\u0010\b\u001a\u00020\u0002H\u0002¢\u0006\u0004\b\b\u0010\u0004J\u000f\u0010\t\u001a\u00020\u0002H\u0002¢\u0006\u0004\b\t\u0010\u0004J\u0019\u0010\f\u001a\u00020\u00022\b\u0010\u000b\u001a\u0004\u0018\u00010\nH\u0014¢\u0006\u0004\b\f\u0010\r¨\u0006\u0011"}, d2 = {"Lcom/bytedance/ads/convert/BDBridgeActivity;", "Landroid/app/Activity;", "", "autoJump", "()V", "", "jumpByDeeplink", "()Z", "jumpByPackage", "reportAndSaveClickId", "Landroid/os/Bundle;", "savedInstanceState", "onCreate", "(Landroid/os/Bundle;)V", "<init>", "Companion", "a", "convert_release"}, k = 1, mv = {1, 4, 0})
public final class BDBridgeActivity extends Activity {
    private static final String START_ONLY_FOR_ANDROID = "start_only_for_android";
    private static final String TAG = "Convert:BridgeActivity";
    private HashMap _$_findViewCache;

    private final void autoJump() {
        Intrinsics.checkNotNullParameter(TAG, "tag");
        Intrinsics.checkNotNullParameter("auto jump by bridge", "msg");
        if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
            Log.d(TAG, "auto jump by bridge");
        }
        if (jumpByDeeplink()) {
            return;
        }
        jumpByPackage();
    }

    private final boolean jumpByDeeplink() {
        String stringExtra = getIntent().getStringExtra(AdBaseConstants.MARKET_OPEN_INTENT_OPEN_URL);
        if (TextUtils.isEmpty(stringExtra)) {
            return false;
        }
        Uri uri = Uri.parse(stringExtra);
        Intent intent = new Intent("android.intent.action.VIEW");
        intent.setData(uri);
        intent.addFlags(C.ENCODING_PCM_MU_LAW);
        intent.putExtra(AdBaseConstants.MARKET_OPEN_INTENT_OPEN_URL, stringExtra);
        intent.putExtra("start_only_for_android", true);
        intent.putExtra("is_convert_bridge", true);
        try {
            startActivity(intent);
            Intrinsics.checkNotNullParameter(TAG, "tag");
            Intrinsics.checkNotNullParameter("jumpByDeeplink: ", "msg");
            if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                Log.d(TAG, "jumpByDeeplink: ");
            }
            return true;
        } catch (ActivityNotFoundException e) {
            Intrinsics.checkNotNullParameter(TAG, "tag");
            Intrinsics.checkNotNullParameter("jumpByDeeplink: ", "msg");
            if (!BDConvert.INSTANCE.getConfig().getEnableLog()) {
                return false;
            }
            Log.e(TAG, "jumpByDeeplink: ", e);
            return false;
        }
    }

    private final void jumpByPackage() {
        String packageName = getPackageName();
        Intent launchIntentForPackage = getPackageManager().getLaunchIntentForPackage(packageName);
        if (launchIntentForPackage != null) {
            Intrinsics.checkNotNullExpressionValue(launchIntentForPackage, "packageManager.getLaunch…ge(thisPackage) ?: return");
            launchIntentForPackage.setPackage(null);
            launchIntentForPackage.addFlags(2097152);
            launchIntentForPackage.addFlags(C.ENCODING_PCM_MU_LAW);
            launchIntentForPackage.putExtra("is_convert_bridge", true);
            startActivity(launchIntentForPackage);
            String msg = "jumpByPackage: " + packageName;
            Intrinsics.checkNotNullParameter(TAG, "tag");
            Intrinsics.checkNotNullParameter(msg, "msg");
            if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                Log.d(TAG, msg);
            }
        }
    }

    private final void reportAndSaveClickId() {
        Intent intent = getIntent();
        String stringExtra = intent.getStringExtra(AdBaseConstants.MARKET_OPEN_CLICK_ID);
        String stringExtra2 = intent.getStringExtra("click_id_nature");
        String stringExtra3 = intent.getStringExtra("hume_channel_id");
        if (!TextUtils.isEmpty(stringExtra)) {
            d.f1704a.a(this, new c(stringExtra, stringExtra2, stringExtra3, f.Jump));
        }
    }

    public void _$_clearFindViewByIdCache() {
        HashMap map = this._$_findViewCache;
        if (map != null) {
            map.clear();
        }
    }

    public View _$_findCachedViewById(int i) {
        if (this._$_findViewCache == null) {
            this._$_findViewCache = new HashMap();
        }
        View view = (View) this._$_findViewCache.get(Integer.valueOf(i));
        if (view != null) {
            return view;
        }
        View viewFindViewById = findViewById(i);
        this._$_findViewCache.put(Integer.valueOf(i), viewFindViewById);
        return viewFindViewById;
    }

    @Override // android.app.Activity
    public void onCreate(Bundle savedInstanceState) {
        Intrinsics.checkNotNullParameter(TAG, "tag");
        Intrinsics.checkNotNullParameter("onCreate: BDBridgeActivity", "msg");
        if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
            Log.d(TAG, "onCreate: BDBridgeActivity");
        }
        try {
            reportAndSaveClickId();
        } catch (Throwable th) {
            Intrinsics.checkNotNullParameter(TAG, "tag");
            Intrinsics.checkNotNullParameter("onCreate: ", "msg");
            if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
                Log.e(TAG, "onCreate: ", th);
            }
        }
        autoJump();
        finish();
        super.onCreate(savedInstanceState);
    }
}
