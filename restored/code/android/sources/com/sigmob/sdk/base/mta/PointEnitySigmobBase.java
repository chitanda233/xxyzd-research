package com.sigmob.sdk.base.mta;

import com.czhj.sdk.common.mta.DeviceContext;
import com.czhj.sdk.common.mta.PointEntityBase;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.b;
import com.sigmob.sdk.base.i;
import com.sigmob.sdk.base.o;
import com.sigmob.sdk.base.utils.f;
import com.sigmob.windad.WindAds;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class PointEnitySigmobBase extends PointEntityBase {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f3222a;
    private String b;
    private String c;

    @Override // com.czhj.sdk.common.mta.PointEntitySuper
    public String appId() {
        return WindAds.sharedAds().getAppId();
    }

    @Override // com.czhj.sdk.common.mta.PointEntitySuper
    public DeviceContext getDeviceContext() {
        return b.b();
    }

    public String getIs_custom_android_id() {
        return this.b;
    }

    public String getIs_custom_imei() {
        return this.f3222a;
    }

    public String getIs_custom_oaid() {
        return this.c;
    }

    @Override // com.czhj.sdk.common.mta.PointEntitySuper
    public String getSdkversion() {
        return "4.25.14";
    }

    @Override // com.czhj.sdk.common.mta.PointEntitySuper
    public boolean isAcTypeBlock() {
        if (!i.a().i()) {
            return true;
        }
        List<Integer> listM = o.a().M();
        if (f.a(listM)) {
            return false;
        }
        Iterator<Integer> it = listM.iterator();
        while (it.hasNext()) {
            if (getAc_type().equals(String.valueOf(it.next()))) {
                SigmobLog.e("black ac type " + getAc_type());
                return true;
            }
        }
        return false;
    }

    public void setIs_custom_android_id(String is_custom_android_id) {
        this.b = is_custom_android_id;
    }

    public void setIs_custom_imei(String is_custom_imei) {
        this.f3222a = is_custom_imei;
    }

    public void setIs_custom_oaid(String is_custom_oaid) {
        this.c = is_custom_oaid;
    }
}
