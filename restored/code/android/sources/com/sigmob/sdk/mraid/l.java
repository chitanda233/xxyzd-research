package com.sigmob.sdk.mraid;

import android.content.Context;
import android.view.View;
import android.widget.FrameLayout;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.logger.SigmobLogger;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.SensorEntity;
import com.sigmob.sdk.base.views.ac;
import com.sigmob.sdk.base.views.am;
import com.sigmob.sdk.base.views.ap;
import com.sigmob.sdk.base.views.aw;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class l extends o {
    private final String e;
    private com.sigmob.sdk.base.views.v f;

    /* JADX WARN: Code duplicated, block: B:18:0x0037  */
    /* JADX WARN: Code duplicated, block: B:21:0x0044  */
    /* JADX WARN: Code duplicated, block: B:23:? A[RETURN, SYNTHETIC] */
    public l(Context context, String uniqueId, int type, BaseAdUnit adUnit) {
        com.sigmob.sdk.base.views.v acVar;
        super(uniqueId);
        this.e = com.kuaishou.weapon.p0.t.d;
        if (type == 0) {
            acVar = new ac(context);
        } else if (type == 1) {
            acVar = new aw(context);
        } else {
            if (type != 2) {
                if (type == 3) {
                    acVar = new ap(context);
                }
                a(context, type);
                if (com.sigmob.sdk.base.utils.v.b(this.f)) {
                    this.f.a();
                }
                if (com.sigmob.sdk.base.utils.v.b(this.c)) {
                    this.c.a(SensorEntity.format(adUnit));
                }
            }
            acVar = new am(context);
        }
        this.f = acVar;
        a(context, type);
        if (com.sigmob.sdk.base.utils.v.b(this.f)) {
            this.f.a();
        }
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.a(SensorEntity.format(adUnit));
        }
    }

    @Override // com.sigmob.sdk.mraid.n
    public View a() {
        return this.f;
    }

    @Override // com.sigmob.sdk.mraid.o
    public void a(float progress) {
        com.sigmob.sdk.base.views.v vVar = this.f;
        if (vVar != null && (vVar instanceof ap)) {
            ((ap) vVar).a(progress);
            SigmobLogger.d(this.e, "onMotionViewUpdateProcess: progress = " + progress, new Object[0]);
        }
    }

    public void a(JSONObject args) {
        JSONObject jSONObjectOptJSONObject;
        if (this.f == null || args == null || (jSONObjectOptJSONObject = args.optJSONObject("frame")) == null) {
            return;
        }
        Context contextE = com.sigmob.sdk.b.e();
        int iOptDouble = (int) jSONObjectOptJSONObject.optDouble("x", 0.0d);
        int iOptDouble2 = (int) jSONObjectOptJSONObject.optDouble("y", 0.0d);
        int iOptDouble3 = (int) jSONObjectOptJSONObject.optDouble(IAdInterListener.AdReqParam.WIDTH, -1.0d);
        int iOptDouble4 = (int) jSONObjectOptJSONObject.optDouble("h", -1.0d);
        if (iOptDouble3 > 0) {
            iOptDouble3 = Dips.dipsToIntPixels(iOptDouble3, contextE);
        }
        if (iOptDouble4 > 0) {
            iOptDouble4 = Dips.dipsToIntPixels(iOptDouble4, contextE);
        }
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(iOptDouble3, iOptDouble4);
        this.f.setX(Dips.dipsToIntPixels(iOptDouble, contextE));
        this.f.setY(Dips.dipsToIntPixels(iOptDouble2, contextE));
        this.f.setLayoutParams(layoutParams);
        this.f.requestLayout();
    }

    public void a(boolean hidden) {
        if (this.f == null || this.c == null) {
            return;
        }
        if (hidden) {
            this.f.setVisibility(4);
            this.c.b();
        } else {
            this.f.setVisibility(0);
            this.c.a();
        }
    }

    @Override // com.sigmob.sdk.mraid.n
    public void b() {
        if (com.sigmob.sdk.base.utils.v.b(this.f)) {
            com.sigmob.sdk.base.utils.w.a(this.f);
            this.f = null;
        }
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.c();
        }
    }

    @Override // com.sigmob.sdk.mraid.o
    public void b(float progress) {
        com.sigmob.sdk.base.views.v vVar = this.f;
        if (vVar != null && (vVar instanceof am)) {
            ((am) vVar).a(progress);
            SigmobLogger.d(this.e, "onMotionViewUpdateScreen: progress = " + progress, new Object[0]);
        }
    }
}
