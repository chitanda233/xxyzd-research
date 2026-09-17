package com.sigmob.sdk.base;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import com.bykv.vk.component.ttvideo.player.C;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.Constants;
import com.sigmob.sdk.base.common.AdActivity;
import com.sigmob.sdk.base.common.BaseBroadcastReceiver;
import com.sigmob.sdk.base.common.LandscapeAdActivity;
import com.sigmob.sdk.base.common.LandscapeTransparentAdActivity;
import com.sigmob.sdk.base.common.PortraitAdActivity;
import com.sigmob.sdk.base.common.PortraitTransparentAdActivity;
import com.sigmob.sdk.base.common.TransparentAdActivity;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.IntentActions;
import java.util.HashMap;

/* JADX INFO: loaded from: classes3.dex */
public class BaseAdActivity extends Activity {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3125a = "LandPage";
    public static final String b = "reward";
    public static final String c = "mraid";
    public static final String d = "mraid_two";
    public static final String e = "LandNative";
    public static final String f = "DisLike";
    protected static final String g = "ad_view_class_name";
    protected static final String h = "adUnit_requestId_key";
    public static final String i = "land_page_url";
    public static final String j = "new_interstitial";

    private static Intent a(Context context, Class<? extends BaseAdActivity> cls, String uuid, String adCls) {
        Intent intentPutExtra = new Intent(context, cls).setFlags(C.ENCODING_PCM_MU_LAW).putExtra(g, adCls).putExtra(h, uuid);
        int requestedOrientation = context instanceof Activity ? ((Activity) context).getRequestedOrientation() : 3;
        if (requestedOrientation != 7 && requestedOrientation != 6) {
            requestedOrientation = context.getResources().getDisplayMetrics().widthPixels > context.getResources().getDisplayMetrics().heightPixels ? 6 : 7;
        }
        intentPutExtra.putExtra(n.x, requestedOrientation);
        intentPutExtra.putExtra(Constants.BROADCAST_IDENTIFIER_KEY, uuid);
        return intentPutExtra;
    }

    public static void a(Context context, Class<? extends BaseAdActivity> cls, BaseAdUnit adUnit) {
        try {
            context.startActivity(a(context, cls, adUnit.getUuid(), f3125a));
        } catch (Throwable th) {
            new HashMap().put("error", th.getMessage());
        }
    }

    public static void a(Context context, Class<? extends BaseAdActivity> cls, String uuid) {
        a(context, cls, uuid, null, f3125a);
    }

    public static void a(Context context, Class<? extends BaseAdActivity> cls, String uuid, Bundle bundle, String adClass) {
        Class cls2;
        try {
            int display_orientation = com.sigmob.sdk.base.common.h.c(uuid).getDisplay_orientation();
            if (display_orientation == 0) {
                display_orientation = ClientMetadata.getInstance().getOrientationInt().intValue();
            }
            if (cls == TransparentAdActivity.class) {
                if (display_orientation != 1) {
                    cls2 = display_orientation != 2 ? TransparentAdActivity.class : LandscapeTransparentAdActivity.class;
                } else {
                    cls2 = PortraitTransparentAdActivity.class;
                }
            } else if (display_orientation != 1) {
                cls2 = display_orientation != 2 ? AdActivity.class : LandscapeAdActivity.class;
            } else {
                cls2 = PortraitAdActivity.class;
            }
            Intent intentA = a(context, cls2, uuid, adClass);
            if (bundle != null) {
                intentA.putExtras(bundle);
            }
            context.startActivity(intentA);
        } catch (Throwable th) {
            HashMap map = new HashMap();
            map.put("error", th.getMessage());
            BaseBroadcastReceiver.a(context, uuid, map, IntentActions.ACTION_REWARDED_VIDEO_PLAYFAIL);
        }
    }

    public static void b(Context context, Class<? extends BaseAdActivity> cls, String uuid) {
        try {
            Intent intentPutExtra = new Intent(context, cls).setFlags(C.ENCODING_PCM_MU_LAW).putExtra(g, f).putExtra(h, uuid);
            intentPutExtra.putExtra(Constants.BROADCAST_IDENTIFIER_KEY, "dislike_broadcastIdentifier");
            context.startActivity(intentPutExtra);
        } catch (Throwable th) {
            th.printStackTrace();
        }
    }
}
