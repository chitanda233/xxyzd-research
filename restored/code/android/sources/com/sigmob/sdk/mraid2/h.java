package com.sigmob.sdk.mraid2;

import android.view.View;
import com.sigmob.sdk.base.models.SensorEntity;

/* JADX INFO: loaded from: classes3.dex */
public class h extends com.sigmob.sdk.mraid.o {
    public h(String uniqueId, String type) {
        super(uniqueId);
        a(com.sigmob.sdk.b.e(), type);
    }

    @Override // com.sigmob.sdk.mraid.n
    public View a() {
        return null;
    }

    @Override // com.sigmob.sdk.mraid.o
    public void a(float progress) {
    }

    public void a(SensorEntity entity) {
        if (this.c == null) {
            return;
        }
        this.c.a(entity);
    }

    @Override // com.sigmob.sdk.mraid.n
    public void b() {
        this.d = null;
        if (this.c == null) {
            return;
        }
        this.c.c();
    }

    @Override // com.sigmob.sdk.mraid.o
    public void b(float progress) {
    }
}
