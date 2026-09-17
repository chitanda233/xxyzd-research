package com.kwad.components.ad.reward.l;

import com.kwad.sdk.utils.ac;
import java.util.Observable;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class b extends Observable implements c, com.kwad.sdk.core.b {
    private boolean Cl = false;
    protected String Cm;
    protected String Cn;

    public final void kW() {
        if (this.Cl) {
            return;
        }
        this.Cl = true;
        lb();
    }

    public final void kX() {
        if (this.Cl) {
            this.Cl = false;
            lb();
        }
    }

    @Override // com.kwad.components.ad.reward.l.c
    public final String kY() {
        return this.Cm;
    }

    @Override // com.kwad.components.ad.reward.l.c
    public final String kZ() {
        return this.Cn;
    }

    public boolean isCompleted() {
        return la();
    }

    public JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.putValue(jSONObject, "selfCompleted", this.Cl);
        return jSONObject;
    }

    public void parseJson(JSONObject jSONObject) {
        try {
            this.Cl = jSONObject.optBoolean("selfCompleted");
        } catch (Throwable unused) {
        }
    }

    private boolean la() {
        return this.Cl;
    }

    private void lb() {
        setChanged();
        notifyObservers(Boolean.valueOf(this.Cl));
    }
}
